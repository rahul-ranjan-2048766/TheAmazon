using Amazon_.Config;
using Amazon_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Amazon_.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int UserId)
        {
            var user = new User();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/User/");
                var responseTask = client.GetAsync("GetUserById/" + UserId);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<User>();
                    reader.Wait();
                    user = reader.Result;
                }
            }
            return user;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/User/");
                var responseTask = client.GetAsync("GetUsers");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<User>>();
                    reader.Wait();
                    users = reader.Result;
                }
            }
            return users;
        }

        public List<MetaData> GetCartMetaData()
        {
            List<MetaData> carts = new List<MetaData>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Meta/");
                var responseTask = client.GetAsync("GetMetas");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<MetaData>>();
                    reader.Wait();
                    carts = reader.Result;
                }
            }
            return carts;
        }

        public void AddMeta(MetaData meta, string adminToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Meta/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
                var responseTask = client.PostAsJsonAsync("AddMeta", meta);
                responseTask.Wait();
            }
        }

        public string AddUser(User user)
        {
            string text = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/User/");
                var responseTask = client.PostAsJsonAsync("AddUser", user);
                responseTask.Wait();
                var result = responseTask.Result;
                var reader = result.Content.ReadAsStringAsync();
                reader.Wait();
                text = reader.Result;
            }
            return text;
        }

        public Tuple<string, int> UpdateUser(User userData, string userToken)
        {
            string text = null;
            int flag = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/User/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                var responseTask = client.PutAsJsonAsync("UpdateUser", userData);
                responseTask.Wait();
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    flag = 1;
                }
                var reader = result.Content.ReadAsStringAsync();
                reader.Wait();
                text = reader.Result;
            }
            return new Tuple<string, int>(text, flag);
        }

        public void DeleteUser(int UserId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/User/");
                var responseTask = client.DeleteAsync("DeleteUser/" + UserId);
                responseTask.Wait();
            }
        }

        public Tuple<Response, string> AuthenticateUser(UserCred userCred)
        {
            var response = new Response();
            string text = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Authenticate/");
                var responseTask = client.PostAsJsonAsync("Authenticate", userCred);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<Response>();
                    reader.Wait();
                    response = reader.Result;                    
                }
                else
                {
                    var reader = result.Content.ReadAsStringAsync();
                    reader.Wait();
                    text = reader.Result;
                }
            }
            return new Tuple<Response, string>(response, text);
        }

        public List<Cart> GetCarts()
        {
            List<Cart> carts = new List<Cart>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Cart/");
                var responseTask = client.GetAsync("GetCarts");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<Cart>>();
                    reader.Wait();
                    carts = reader.Result;
                }
            }
            return carts;
        }

        public Cart GetCartById(int CartId)
        {
            var cart = new Cart();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Cart/");
                var responseTask = client.GetAsync("GetCartById/" + CartId);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<Cart>();
                    reader.Wait();
                    cart = reader.Result;
                }
            }
            return cart;
        }

        public string AddCart(Cart cart, string userToken)
        {
            string text = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Cart/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                var responseTask = client.PostAsJsonAsync("AddCart", cart);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsStringAsync();
                    reader.Wait();
                    text = reader.Result;
                }
            }
            return text;
        }

        public void DeleteCart(int CartId, string userToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Cart/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                var responseTask = client.DeleteAsync("DeleteCart/" + CartId);
                responseTask.Wait();                
            }
        }

        public void ReducePurchasedProductQuantity(int ProductId, int QuantityOrdered)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/ReduceQuantity/");
                var responseTask = client.DeleteAsync("ReduceQuantity/" + ProductId + "/" + QuantityOrdered);
                responseTask.Wait();
            }
        }

        public void IncreaseQuantityAfterCancellation(int ProductId, int QuantityOrdered)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/ReduceQuantity/");
                var responseTask = client.GetAsync("IncreaseQuantity/" + ProductId + "/" + QuantityOrdered);
                responseTask.Wait();
            }
        }

        public void UpdateCountAfterCancellation(int ProductId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/UpdateProduct/");
                var responseTask = client.GetAsync("UpdateCount/" + ProductId);
                responseTask.Wait();
            }
        }

        public void DeleteCartsByProductId(int ProductId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/UpdateCart/");
                var responseTask = client.DeleteAsync("DeleteCartsByProductId/" + ProductId);
                responseTask.Wait();
            }
        }

        public void DeleteCartsByUserId(int UserId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.UserMicroservice + "api/Authenticate/");
                var responseTask = client.DeleteAsync("DeleteCartsByUserId/" + UserId);
                responseTask.Wait();
            }
        }
    }
}
