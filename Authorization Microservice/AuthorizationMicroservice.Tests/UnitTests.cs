using Authorization_Microservice.Controllers;
using Authorization_Microservice.Helpers;
using Authorization_Microservice.Models;
using Authorization_Microservice.Repositories;
using Authorization_Microservice.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using Xunit;

namespace AuthorizationMicroservice.Tests
{
    public class UnitTests
    {
        private readonly IProductRepository productRepository;
        private readonly IProductService productService;
        private readonly IMetaDataRepository metaDataRepository;
        private readonly IMetaDataService metaDataService;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICategoryService categoryService;
        private readonly IAdminRepository adminRepository;
        private readonly IAdminService adminService;

        static string ConnectionString = @"Data Source=127.0.0.1\{sql2019},1433;Initial Catalog=AmazonDatabaseDummyDb;User ID=SA;Password=India46@$";
        private static DbContextOptions<ApplicationDbContext> dbContextOptions;

        static UnitTests() => dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(ConnectionString).Options;
        public UnitTests()
        {
            ApplicationDbContext context = new ApplicationDbContext(dbContextOptions);
            DummyDbInitializer dummy = new DummyDbInitializer();
            dummy.Seed(context);
            adminRepository = new AdminRepository(context);
            adminService = new AdminService(adminRepository);
            categoryRepository = new CategoryRepository(context);
            categoryService = new CategoryService(categoryRepository);
            metaDataRepository = new MetaDataRepository(context);
            metaDataService = new MetaDataService(metaDataRepository);
            productRepository = new ProductRepository(context);
            productService = new ProductService(productRepository);
        }

        // AdminController

        [Fact]
        public void AddAdmin_PositiveTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.AddAdmin(new Admin 
                { 
                    Id = 0,
                    UserName = "UserName",
                    Email = "Email",
                    Password = "Password"
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddAdmin_Negative_Test()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.AddAdmin(new Admin 
                { 
                    Id = 46,
                    UserName = "UserName46",
                    Email = "Email46",
                    Password = "Password46"
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteAdmin_PositiveTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.DeleteAdmin(6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteAdmin_NegativeTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.DeleteAdmin(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetAdminById_PositiveTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.GetAdminById(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAdminById_NegativeTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.GetAdminById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetAdmins_UnitTest()
        {
            AdminController adminController = new AdminController(adminService);
            var result = adminController.GetAdmins();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateAdmin_PositiveTest()
        {
            AdminController adminController = new AdminController(adminService);
            var getAdmin = adminController.GetAdminById(6);
            var result1 = getAdmin.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Admin>().Subject;
            var putAdmin = adminController.UpdateAdmin(result2);
            Assert.IsType<OkObjectResult>(putAdmin);
        }

        [Fact]
        public void UpdateAdmin_NegativeTest()
        {
            AdminController adminController = new AdminController(adminService);
            var getAdmin = adminController.GetAdminById(4);
            var result1 = getAdmin.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Admin>().Subject;
            result2.Id = 0;
            var putAdmin = adminController.UpdateAdmin(result2);
            Assert.IsType<BadRequestObjectResult>(putAdmin);
        }

        // AuthenticateController

        [Fact]
        public void Authenticate_Positive()
        {
            Mock<IConfiguration> mock = new Mock<IConfiguration>();
            mock.Setup(x => x["JWT:SecretKey"]).Returns("3YnZxTu75wXBXnXC6H5M6hUJx8vnbsVfmPRdcWtS7X7M24ym6CAkvFT6R4XtLw3UQXLtLE9b2SwT3v2L");
            IJwtAuthenticateManager manager = new JwtAuthenticateManager(mock.Object, adminService);
            AuthenticateController controller = new AuthenticateController(manager);
            var result = controller.Authenticate(new UserCred 
                { 
                    UserName = "UserName4",
                    Password = "Password4"
            });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Authenticate_Negative()
        {
            Mock<IConfiguration> mock = new Mock<IConfiguration>();
            mock.Setup(x => x["JWT:Secret"]).Returns("3YnZxTu75wXBXnXC6H5M6hUJx8vnbsVfmPRdcWtS7X7M24ym6CAkvFT6R4XtLw3UQXLtLE9b2SwT3v2L");
            IJwtAuthenticateManager manager = new JwtAuthenticateManager(mock.Object, adminService);
            AuthenticateController controller = new AuthenticateController(manager);
            var result = controller.Authenticate(new UserCred 
                { 
                    UserName = "sjdhvjwebvjhbjvhb",
                    Password = "iwjevfkjebrvberwa"
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        // CategoryController

        [Fact]
        public void AddCategory_PositiveTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.AddCategory(new Category 
                { 
                    Id = 0,
                    CategoryName = "Category46",
                    DateTime = DateTime.Now
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddCategory_NegativeTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.AddCategory(new Category 
                {
                    Id = 46,
                    CategoryName = "Category46",
                    DateTime = DateTime.Now
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteCategory_PositiveTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.DeleteCategory(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteCategory_NegativeTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.DeleteCategory(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetCategoryById_PositiveTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.GetCategoryById(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetCategoryById_NegativeTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.GetCategoryById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetCategories_UnitTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var result = categoryController.GetCategories();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateCategory_PositiveTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var getCategory = categoryController.GetCategoryById(4);
            var result1 = getCategory.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Category>().Subject;
            var putCategory = categoryController.UpdateCategory(result2);
            Assert.IsType<OkObjectResult>(putCategory);
        }

        [Fact]
        public void UpdateCategory_NegativeTest()
        {
            CategoryController categoryController = new CategoryController(categoryService);
            var getCategory = categoryController.GetCategoryById(6);
            var result1 = getCategory.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Category>().Subject;
            result2.Id = 0;
            var putCategory = categoryController.UpdateCategory(result2);
            Assert.IsType<BadRequestObjectResult>(putCategory);
        }

        // MetaController
        
        //[Fact]
        //public void AddMeta_PositiveTest()
        //{
        //    MetaController metaController = new MetaController(metaDataService);
        //    var result = metaController.AddMeta(new MetaData 
        //        { 
        //            Id = 0, CartId = 4, ProductId = 4, UserId = 4
        //        });
        //    Assert.IsType<OkObjectResult>(result);
        //}

        [Fact]
        public void AddMeta_NegativeTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.AddMeta(new MetaData 
                { 
                    Id = 6, CartId = 6, ProductId = 6, UserId = 6
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteMeta_PositiveTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.DeleteMeta(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteMeta_NegativeTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.DeleteMeta(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetMetaById_PositiveTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.GetMetaById(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetMetaById_NegativeTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.GetMetaById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetMetas_UnitTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var result = metaController.GetMetas();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateMeta_PositiveTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var getMeta = metaController.GetMetaById(4);
            var result1 = getMeta.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<MetaData>().Subject;
            var putMeta = metaController.UpdateMeta(result2);
            Assert.IsType<OkObjectResult>(putMeta);
        }

        [Fact]
        public void UpdateMeta_NegativeTest()
        {
            MetaController metaController = new MetaController(metaDataService);
            var getMeta = metaController.GetMetaById(6);
            var result1 = getMeta.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<MetaData>().Subject;
            result2.Id = 0;
            var putMeta = metaController.UpdateMeta(result2);            
            Assert.IsType<BadRequestObjectResult>(putMeta);
        }

        // ProductController

        [Fact]
        public void AddProduct_PositiveTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.AddProduct(new Product 
                { 
                    Id = 0, ProductName = "Product46", ProductCategory = "Category46", ImageUrl = "ImageUrl46", Description = "Description46", Company = "Company46", Price = 400, Quantity = 60, Count = 46, DateTime = DateTime.Now
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddProduct_NegativeTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.AddProduct(new Product 
                { 
                    Id = 46, ProductName = "Product46", ProductCategory = "Category46", Company = "Company46", Description = "Description46", ImageUrl = "ImageUrl46", Price = 400, Quantity = 60, Count = 46, DateTime = DateTime.Now
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteProduct_Positivetest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.DeleteProduct(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteProduct_NegativeTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.DeleteProduct(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetProductsById_PositiveTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.GetProductsById(6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetProductsById_NegativeTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.GetProductsById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetProducts_UnitTest()
        {
            ProductController productController = new ProductController(productService);
            var result = productController.GetProducts();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateProduct_PositiveTest()
        {
            ProductController productController = new ProductController(productService);
            var getProduct = productController.GetProductsById(4);
            var result1 = getProduct.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Product>().Subject;
            var putProduct = productController.UpdateProduct(result2);
            Assert.IsType<OkObjectResult>(putProduct);
        }

        [Fact]
        public void UpdateProduct_NegativeTest()
        {
            ProductController productController = new ProductController(productService);
            var getProduct = productController.GetProductsById(6);
            var result1 = getProduct.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Product>().Subject;
            result2.Id = 0;
            var putProduct = productController.UpdateProduct(result2);
            Assert.IsType<BadRequestObjectResult>(putProduct);
        }

        // ReduceQuantityController

        [Fact]
        public void ReduceQuantity_PositiveTest()
        {
            ReduceQuantityController controller = new ReduceQuantityController(productService);
            var result = controller.ReduceQuantity(4, 6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ReduceQuantity_NegativeTest()
        {
            ReduceQuantityController controller = new ReduceQuantityController(productService);
            var result = controller.ReduceQuantity(46, 46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void IncreaseQuantity_PositiveTest()
        {
            ReduceQuantityController controller = new ReduceQuantityController(productService);
            var result = controller.IncreaseQuantity(6, 4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void IncreaseQuantity_NegativeTest()
        {
            ReduceQuantityController controller = new ReduceQuantityController(productService);
            var result = controller.IncreaseQuantity(46, 46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        // UpdateProductController

        [Fact]
        public void UpdateCount_PositiveTest()
        {
            UpdateProductController controller = new UpdateProductController(productService);
            var result = controller.UpdateCount(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateCount_NegativeTest()
        {
            UpdateProductController controller = new UpdateProductController(productService);
            var result = controller.UpdateCount(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
