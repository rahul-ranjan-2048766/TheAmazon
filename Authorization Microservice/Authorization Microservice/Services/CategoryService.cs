using Authorization_Microservice.Models;
using Authorization_Microservice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            repository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            repository.AddCategory(category);
        }

        public void DeleteCategory(int id)
        {
            repository.DeleteCategory(id);
        }

        public List<Category> GetCategories()
        {
            return repository.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return repository.GetCategoryById(id);
        }

        public void UpdateCategory(Category category)
        {
            repository.UpdateCategory(category);
        }
    }
}
