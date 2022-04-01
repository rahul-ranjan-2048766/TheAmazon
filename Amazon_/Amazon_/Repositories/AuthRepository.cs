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
    public class AuthRepository : IAuthRepository
    {
        public Tuple<Response, string> Authenticate(UserCred userCred)
        {
            Response response = new Response();
            string text = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Authenticate/");
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

        public void AddCategory(Category category, string adminToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Category/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
                var responseTask = client.PostAsJsonAsync<Category>("AddCategory", category);
                responseTask.Wait();
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Category/");
                var responseTask = client.GetAsync("GetCategories");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<Category>>();
                    reader.Wait();
                    categories = reader.Result;
                }
            }
            return categories;
        }

        public string AddProduct(Product product, string adminToken)
        {
            string text = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Product/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
                var responseTask = client.PostAsJsonAsync("AddProduct", product);
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

        public Product GetProductById(int id)
        {
            var product = new Product();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Product/");
                var responseTask = client.GetAsync("GetProductsById/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<Product>();
                    reader.Wait();
                    product = reader.Result;
                }
            }
            return product;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Product/");
                var responseTask = client.GetAsync("GetProducts");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var reader = result.Content.ReadAsAsync<List<Product>>();
                    reader.Wait();
                    products = reader.Result.OrderByDescending(x => x.Count).ToList();
                }
            }
            return products;
        }

        public string UpdateProduct(Product product, string adminToken)
        {
            string text = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Product/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", adminToken);
                var responseTask = client.PutAsJsonAsync("UpdateProduct", product);
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

        public void DeleteProduct(int ProductId, string userToken)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Urls.AuthorizationMicroservice + "api/Product/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
                var responseTask = client.DeleteAsync("DeleteProduct/" + ProductId);
                responseTask.Wait();
            }
        }
    }
}
