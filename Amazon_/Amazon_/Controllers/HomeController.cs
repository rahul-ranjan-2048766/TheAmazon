using Amazon_.Config;
using Amazon_.Models;
using Amazon_.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Amazon_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthService authService;
        private readonly IUserService userService;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment, IAuthService auth, IUserService user)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            authService = auth;
            userService = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Site()
        {
            try
            {
                var products = authService.GetProducts();
                var categories = authService.GetCategories();

                Tuple<List<Product>, List<Category>> tuple = new Tuple<List<Product>, List<Category>>(products, categories);

                var user = HttpContext.Session.GetString("UserName");
                var token = HttpContext.Session.GetString("UserToken");

                if (user != null && token != null)
                    ViewBag.User = user;

                return View(tuple);
            }
            catch
            {
                return Content("Either the authorization microservice is not operational or the MSSQL image of docker is not operational.");
            }
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdminPanel(string username, string password)
        {
            var result = authService.Authenticate(new UserCred 
            {
                UserName = username,
                Password = password
            });

            if(result.Item2 != null)
            {
                ViewBag.message = result.Item2;
                return View("AdminPanel");
            }

            HttpContext.Session.SetString("Admin_UserName", result.Item1.UserName);
            HttpContext.Session.SetString("Admin_Token", result.Item1.Token);
            HttpContext.Session.SetString("Admin_ValidFrom", result.Item1.ValidFrom.ToString());
            HttpContext.Session.SetString("Admin_ValidTo", result.Item1.ValidTo.ToString());

            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Categories()
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var categories = authService.GetCategories();

            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Categories(string category)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            if(category == null)
            {
                return RedirectToAction("Categories");
            }

            var data = new Category 
            { 
                CategoryName = category
            };

            authService.AddCategory(data, token);
            
            return RedirectToAction("Categories");
        }

        public IActionResult AddProduct(string text = null)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var categories = authService.GetCategories();

            if (text != null)
                ViewBag.message = text;
                
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(string ProductName, string ProductCategory, double Price, int Quantity, string Company, string Description, IFormFile ImageUrl)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var fileName = Path.GetFileNameWithoutExtension(ImageUrl.FileName) + DateTime.Now.ToString("ddMMyyyyhhmmssfffffff") + Guid.NewGuid() + Path.GetExtension(ImageUrl.FileName);
            var product = new Product 
            { 
                ProductName = ProductName,
                ProductCategory = ProductCategory,
                Price = Price,
                Quantity = Quantity,
                Company = Company,
                Description = Description,
                ImageUrl = "~/media/" + fileName
            };

            var filePath = Path.Combine(_webHostEnvironment.WebRootPath + "/media/", fileName);

            using (var writer = new FileStream(filePath, FileMode.Create))
            {
                ImageUrl.CopyTo(writer);
            }

            var text = authService.AddProduct(product, token);
            return RedirectToAction("AddProduct", new { text = text });
        }

        public IActionResult Products()
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var products = authService.GetProducts();
            return View(products);
        }

        public IActionResult ViewProductToAdmin(int id, string text = null)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var product = authService.GetProductById(id);
            var categories = authService.GetCategories();

            Tuple<Product, List<Category>> tuple = new Tuple<Product, List<Category>>(product, categories);

            if (text != null)
                ViewBag.message = text;
                
            return View(tuple);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ViewProductToAdmin(string ProductName, string ProductCategory, double Price, int Quantity, string Company, string Description, int ProductId)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var product = authService.GetProductById(ProductId);

            product.ProductName = ProductName;
            product.ProductCategory = ProductCategory;
            product.Price = Price;
            product.Quantity = Quantity;
            product.Company = Company;
            product.Description = Description;

            var text = authService.UpdateProduct(product, token);
            return RedirectToAction("ViewProductToAdmin", new { id=ProductId, text=text });
        }

        public PartialViewResult _UpdateImage(Product product)
        {
            return PartialView(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _UpdateImage(int ProductId, IFormFile formFile)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var fileName = Path.GetFileNameWithoutExtension(formFile.FileName) + DateTime.Now.ToString("ddMMyyyyhhmmssfffffff") + Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath + "/media/", fileName);
            using (var writer = new FileStream(filePath, FileMode.Create))
            {
                formFile.CopyTo(writer);
            }

            var product = authService.GetProductById(ProductId);
            product.ImageUrl = "~/media/" + fileName;
            var text = authService.UpdateProduct(product, token);
            return RedirectToAction("ViewProductToAdmin", new { id = ProductId, text = text });
        }

        public IActionResult RemoveCategory(int id)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Category/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseTask = client.DeleteAsync("DeleteCategory/" + id);
                responseTask.Wait();
            }

            return RedirectToAction("Categories");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProductSearch(string product_word)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var products = authService.GetProducts();
            if(product_word == null)
            {
                return RedirectToAction("Products", products);
            }
            var filtered_products = products.Where(x => x.ProductName.ToLower().Contains(product_word.ToLower()) || x.ProductCategory.ToLower().Contains(product_word.ToLower()) || x.Company.ToLower().Contains(product_word.ToLower())).ToList();            
            return View("Products", filtered_products);
        }

        public IActionResult ViewProductToUser(int id)
        {
            var product = authService.GetProductById(id);
            var categories = authService.GetCategories();

            var user = HttpContext.Session.GetString("UserName");
            var token = HttpContext.Session.GetString("UserToken");
            if (user != null && token != null)
                ViewBag.User = user;

            var users = userService.GetUsers();
            var products = authService.GetProducts();
            var carts = userService.GetCartMetaData();
            var list = carts.Where(x => x.ProductId == product.Id).ToList();

            List<int> userIdsOfUsersWhoBoughtThisProduct = new List<int>();
            foreach(var d in list)
            {
                userIdsOfUsersWhoBoughtThisProduct.Add(d.UserId);
            }

            var uniqueUserIds = userIdsOfUsersWhoBoughtThisProduct.Distinct().ToList();
            List<int> productIds = new List<int>();
            List<Cart> cartsOfUsersHavingTheirIdsInUniqueUserIdList = new List<Cart>();
            foreach(var d in uniqueUserIds)
            {
                var newCarts = carts.Where(x => x.UserId == d).ToList();
                foreach(var e in newCarts)
                {
                    productIds.Add(e.ProductId);
                }
            }

            var uniqueProductIds = productIds.Distinct().ToList();
            uniqueProductIds.Remove(id);

            int count = 0;

            List<Product> dataList = new List<Product>();
            foreach(var f in uniqueProductIds)
            {
                dataList.Add(products.FirstOrDefault(x => x.Id == f));
                count++;
                if (count == 5)
                    break;
            }

            var dataList46 = dataList.OrderByDescending(x => x.Count).ToList();
            Tuple<Product, List<Category>, List<Product>> tuple = new Tuple<Product, List<Category>, List<Product>>(product, categories, dataList46);

            return View(tuple);
        }

        public IActionResult SearchProduct(string word)
        {
            if (word == null)
                return RedirectToAction("Site");

            var products = authService.GetProducts();
            var categories = authService.GetCategories();

            var user = HttpContext.Session.GetString("UserName");
            var token = HttpContext.Session.GetString("UserToken");
            if (user != null && token != null)
                ViewBag.User = user;

            var filtered_products = products.Where(x => x.ProductCategory.ToLower().Contains(word.ToLower())).ToList();
            Tuple<List<Product>, List<Category>> tuple = new Tuple<List<Product>, List<Category>>(filtered_products, categories);

            return View("Site", tuple);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(string word)
        {
            if (word == null)
                return RedirectToAction("Site");

            var products = authService.GetProducts();
            var filtered_products = products.Where(x => x.ProductCategory.ToLower().Contains(word.ToLower()) || x.ProductName.ToLower().Contains(word.ToLower())).ToList();

            var categories = authService.GetCategories();

            var user = HttpContext.Session.GetString("UserName");
            var token = HttpContext.Session.GetString("UserToken");
            if (user != null && token != null)
                ViewBag.User = user;

            Tuple<List<Product>, List<Category>> tuple = new Tuple<List<Product>, List<Category>>(filtered_products, categories);
            return View("Site", tuple);
        }

        public IActionResult UserRegister()
        {
            var categories = authService.GetCategories();
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserRegister(string UserName, string Name, string Email, string Password)
        {
            var user = new User 
            { 
                UserName = UserName,
                Name = Name,
                Email = Email,
                Password = Password,
                City = "",
                UserImage = "~/images/Profile-Transparent.png",
                DateTime = DateTime.Now
            };

            var text = userService.AddUser(user);
            ViewBag.message = text;

            return View("UserRegister");
        }

        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserLogin(string Username, string Password)
        {
            var userCred = new UserCred 
            { 
                UserName = Username,
                Password = Password
            };

            var result = userService.AuthenticateUser(userCred);
            if(result.Item2 == null)
            {
                HttpContext.Session.SetString("UserToken", result.Item1.Token);
                HttpContext.Session.SetString("UserName", result.Item1.UserName);
                HttpContext.Session.SetString("User_ValidFrom", result.Item1.ValidFrom.ToString());
                HttpContext.Session.SetString("User_ValidTo", result.Item1.ValidTo.ToString());

                return RedirectToAction("Site");
            }

            ViewBag.message = result.Item2;
            return View("UserLogin");
        }

        public IActionResult UserProfile(string text = null)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");

            if (user == null || userToken == null)
                return RedirectToAction("UserLogin");

            ViewBag.User = user;
            var users = userService.GetUsers();

            var userData = users.FirstOrDefault(x => x.UserName.Equals(user));
            if (userData == null)
                return RedirectToAction("UserLogin");

            var categories = authService.GetCategories();
            Tuple<User, List<Category>> tuple = new Tuple<User, List<Category>>(userData, categories);

            ViewBag.message = text;
            return View(tuple);
        }

        public PartialViewResult _UserImage()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _UserImage(IFormFile formFile)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");

            if (user == null || userToken == null)
                return RedirectToAction("UserLogin");

            var users = userService.GetUsers();
            var userData = users.FirstOrDefault(x => x.UserName.Equals(user));

            var fileName = Path.GetFileNameWithoutExtension(formFile.FileName) + DateTime.Now.ToString("ddMMyyyyhhmmssfffffff") + Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath + "/UserImages/", fileName);

            userData.UserImage = "~/UserImages/" + fileName;
            using (var writer = new FileStream(filePath, FileMode.Create))
            {
                formFile.CopyTo(writer);
            }

            var text = userService.UpdateUser(userData, userToken);
            return RedirectToAction("UserProfile", new { text = text.Item1 });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserProfile(string UserName, string Name, string Email, string City, string Password)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");
            if (user == null && userToken == null)
                return RedirectToAction("UserLogin");

            var users = userService.GetUsers();
            var userData = users.FirstOrDefault(x => x.UserName.Equals(user));

            var usersHavingSameUserName = users.FirstOrDefault(x => x.UserName.Equals(UserName) && x.Id != userData.Id);
            if (usersHavingSameUserName != null)
                return RedirectToAction("UserProfile", new { text = "The username is already taken by somebody else. Please enter a unique username." });

            userData.UserName = UserName;
            userData.Name = Name;
            userData.Email = Email;
            userData.City = City;
            userData.Password = Password;

            var result = userService.UpdateUser(userData, userToken);
            if(result.Item2 == 0)
            {
                return RedirectToAction("UserProfile", new { text = result.Item1 });
            }

            var userCred = new UserCred
            {
                UserName = userData.UserName,
                Password = userData.Password
            };

            var response = userService.AuthenticateUser(userCred);
            if(response.Item2 == null)
            {
                HttpContext.Session.SetString("UserToken", response.Item1.Token);
                HttpContext.Session.SetString("UserName", response.Item1.UserName);
                HttpContext.Session.SetString("User_ValidFrom", response.Item1.ValidFrom.ToString());
                HttpContext.Session.SetString("User_ValidTo", response.Item1.ValidTo.ToString());
            }

            return RedirectToAction("UserProfile", new { text = result.Item1 });
        }

        public IActionResult UserCart()
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");
            if (user == null && userToken == null)
                return RedirectToAction("UserLogin");

            ViewBag.User = user;

            var categories = authService.GetCategories();
            var users = userService.GetUsers();
            var carts = userService.GetCarts();
            var products = authService.GetProducts();

            var userData = users.FirstOrDefault(x => x.UserName.Equals(user));
            var filtered_carts = carts.Where(x => x.UserId == userData.Id).ToList();

            List<CartDetail> cartDetails = new List<CartDetail>();
            foreach(var cart in filtered_carts)
            {
                cartDetails.Add(new CartDetail 
                { 
                    cart = cart,
                    product = products.FirstOrDefault(x => x.Id == cart.ProductId),
                    user = users.FirstOrDefault(x => x.Id == cart.UserId)
                });
            }

            Tuple<List<CartDetail>, List<Category>> tuple = new Tuple<List<CartDetail>, List<Category>>(cartDetails, categories);                
            return View(tuple);
        }

        public IActionResult PlaceOrder(int ProductId, string text = null)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");
            if (user == null || userToken == null)
                return RedirectToAction("UserLogin");

            ViewBag.User = user;
            var categories = authService.GetCategories();
            var product = authService.GetProductById(ProductId);
            Tuple<Product, List<Category>> tuple = new Tuple<Product, List<Category>>(product, categories);

            ViewBag.message = text;

            return View(tuple);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlaceOrder(int QuantityOrdered, string Address, int ProductId)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");
            if (user == null || userToken == null)
                return RedirectToAction("UserLogin");

            var users = userService.GetUsers();
            var userData = users.FirstOrDefault(x => x.UserName.Equals(user));

            var product = authService.GetProductById(ProductId);

            var cart = new Cart
            {
                QuantityOrdered = QuantityOrdered,
                DeliveryAddress = Address,
                ProductId = ProductId,
                UserId = userData.Id,
                NetPrice = QuantityOrdered * product.Price,
                DateTime = DateTime.Now
            };

            var text = userService.AddCart(cart, userToken);
            userService.ReducePurchasedProductQuantity(ProductId, QuantityOrdered);

            return RedirectToAction("PlaceOrder", new { ProductId = ProductId, text = text });
        }

        public IActionResult CancelCart(int CartId)
        {
            var user = HttpContext.Session.GetString("UserName");
            var userToken = HttpContext.Session.GetString("UserToken");
            if (user == null || userToken == null)
                return RedirectToAction("UserLogin");

            var cart = userService.GetCartById(CartId);
            if(cart.Status.ToLower().Equals("not delivered"))
            {
                userService.IncreaseQuantityAfterCancellation(cart.ProductId, cart.QuantityOrdered);
                userService.UpdateCountAfterCancellation(cart.ProductId);                
            }
            userService.DeleteCart(CartId, userToken);
            return RedirectToAction("UserCart");
        }

        public IActionResult Users()
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var users = userService.GetUsers();                
            return View(users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchUser(string search_word)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            if(search_word == null)
            {
                return RedirectToAction("Users");
            }

            var users = userService.GetUsers();
            var list = users.Where(x => x.UserName.ToLower().Contains(search_word.ToLower())
                            || x.Name.ToLower().Contains(search_word.ToLower())
                            || x.Email.ToLower().Contains(search_word.ToLower())
                            || x.City.ToLower().Contains(search_word.ToLower())).ToList();

            return View("Users", list);
        }

        public IActionResult ViewUser(int UserId)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var user = userService.GetUserById(UserId);
            var products = authService.GetProducts();
            var carts = userService.GetCarts();
            var filtered_carts = carts.Where(x => x.UserId == user.Id).ToList();

            List<CartDetail> cartDetails = new List<CartDetail>();
            foreach(var cart in filtered_carts)
            {
                cartDetails.Add(new CartDetail 
                { 
                    cart = cart,
                    product = products.FirstOrDefault(x => x.Id == cart.ProductId),
                    user = user
                });
            }

            Tuple<User, List<CartDetail>> tuple = new Tuple<User, List<CartDetail>>(user, cartDetails);                
            return View(tuple);
        }

        public IActionResult ViewUserCartToAdmin(int CartId)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var cart = userService.GetCartById(CartId);
            var user = userService.GetUserById(cart.UserId);
            var product = authService.GetProductById(cart.ProductId);
            CartDetail data = new CartDetail 
            { 
                cart = cart,
                product = product,
                user = user
            };                
            return View(data);
        }

        public IActionResult Orders()
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            var carts = userService.GetCarts();
            var users = userService.GetUsers();
            var products = authService.GetProducts();
            List<CartDetail> data = new List<CartDetail>();

            foreach(var cart in carts)
            {
                data.Add(new CartDetail 
                { 
                    cart = cart,
                    product = products.FirstOrDefault(x => x.Id == cart.ProductId),
                    user = users.FirstOrDefault(x => x.Id == cart.UserId)
                });
            }  
            
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchCart(string search_word)
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            var carts = userService.GetCarts();
            var users = userService.GetUsers();
            var products = authService.GetProducts();
            List<CartDetail> data = new List<CartDetail>();

            foreach (var cart in carts)
            {
                data.Add(new CartDetail
                {
                    cart = cart,
                    product = products.FirstOrDefault(x => x.Id == cart.ProductId),
                    user = users.FirstOrDefault(x => x.Id == cart.UserId)
                });
            }

            if (search_word == null)
                return RedirectToAction("Orders", data);

            var dataList = data.Where(x => x.user.UserName.ToLower().Contains(search_word.ToLower())
                                    || x.user.Name.ToLower().Contains(search_word.ToLower())
                                    || x.user.Email.ToLower().Contains(search_word.ToLower())
                                    || x.product.ProductName.ToLower().Contains(search_word.ToLower())
                                    || x.product.ProductCategory.ToLower().Contains(search_word.ToLower())
                                    || x.product.Company.ToLower().Contains(search_word.ToLower())
                                    || x.user.City.ToLower().Contains(search_word.ToLower())).ToList();
            
            return View("Orders", dataList);
        }

        public IActionResult ViewCartToAdmin(int CartId)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            var cart = userService.GetCartById(CartId);
            var user = userService.GetUserById(cart.UserId);
            var product = authService.GetProductById(cart.ProductId);
            CartDetail data = new CartDetail
            {
                cart = cart,
                product = product,
                user = user
            };

            return View(data);
        }

        public IActionResult MarkDelivered(int CartId)
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            var cart = userService.GetCartById(CartId);
            var meta = new MetaData 
            { 
                Id = 0,
                CartId = cart.Id,
                ProductId = cart.ProductId,
                UserId = cart.UserId
            };

            userService.AddMeta(meta, AdminToken);
            return RedirectToAction("ViewCartToAdmin", new { CartId = CartId });
        }

        public IActionResult RemoveDetails(int CartId)
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            var cart = userService.GetCartById(CartId);
            if (cart.Status.ToLower().Equals("not delivered"))
            {
                userService.IncreaseQuantityAfterCancellation(cart.ProductId, cart.QuantityOrdered);
                userService.UpdateCountAfterCancellation(cart.ProductId);
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Cart/");
                var responseTask = client.DeleteAsync("DeleteCart/" + CartId);
                responseTask.Wait();

            }

            return RedirectToAction("Orders");
        }

        public IActionResult About()
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");
            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            return View();
        }

        public IActionResult RemoveProduct(int ProductId)
        {
            var token = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (token == null || AdminName == null)
                return RedirectToAction("AdminPanel");

            userService.DeleteCartsByProductId(ProductId);
            authService.DeleteProduct(ProductId, token);

            return RedirectToAction("Products");
        }

        public IActionResult RemoveUser(int UserId)
        {
            var AdminToken = HttpContext.Session.GetString("Admin_Token");
            var AdminName = HttpContext.Session.GetString("Admin_UserName");

            if (AdminToken == null || AdminName == null)
            {
                return RedirectToAction("AdminPanel");
            }

            userService.DeleteCartsByUserId(UserId);
            userService.DeleteUser(UserId);
                
            return RedirectToAction("Users");
        }
    }
}
