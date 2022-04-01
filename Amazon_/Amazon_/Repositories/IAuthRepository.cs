using Amazon_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Repositories
{
    public interface IAuthRepository
    {
        public Tuple<Response, string> Authenticate(UserCred userCred);
        public void AddCategory(Category category, string adminToken);
        public List<Category> GetCategories();
        public string AddProduct(Product product, string adminToken);
        public Product GetProductById(int id);
        public List<Product> GetProducts();
        public string UpdateProduct(Product product, string adminToken);
        public void DeleteProduct(int ProductId, string userToken);
    }
}
