using Authorization_Microservice.Models;
using Authorization_Microservice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        public ProductService(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public void AddProduct(Product product)
        {
            repository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            repository.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return repository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return repository.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            repository.UpdateProduct(product);
        }
    }
}
