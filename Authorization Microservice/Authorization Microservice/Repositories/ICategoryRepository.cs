using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Repositories
{
    public interface ICategoryRepository
    {
        public void AddCategory(Category category);
        public void DeleteCategory(int id);
        public Category GetCategoryById(int id);
        public List<Category> GetCategories();
        public void UpdateCategory(Category category);
    }
}
