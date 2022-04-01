using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Services
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        public void DeleteProduct(int id);
        public Product GetProductById(int id);
        public List<Product> GetProducts();
        public void UpdateProduct(Product product);
    }
}
