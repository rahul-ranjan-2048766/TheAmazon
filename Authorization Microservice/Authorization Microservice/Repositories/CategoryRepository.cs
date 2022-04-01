using Authorization_Microservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            category.DateTime = DateTime.Now;
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
                throw new SystemException();
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
                throw new SystemException();
            return category;
        }

        public void UpdateCategory(Category category)
        {
            category.DateTime = DateTime.Now;
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
