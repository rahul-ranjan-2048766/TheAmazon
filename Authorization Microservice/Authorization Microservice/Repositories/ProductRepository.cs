using Authorization_Microservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            product.DateTime = DateTime.Now;
            product.Count = 0;
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                throw new SystemException();
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                throw new SystemException();
            return product;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
