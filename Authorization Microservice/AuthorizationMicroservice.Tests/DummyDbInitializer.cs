using Authorization_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationMicroservice.Tests
{
    public class DummyDbInitializer
    {
        public DummyDbInitializer() { }
        public void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Admins.AddRange(
                    new Admin { Id = 0, UserName = "UserName1", Email = "Email1", Password = "Password1" },
                    new Admin { Id = 0, UserName = "UserName2", Email = "Email2", Password = "Password2" },
                    new Admin { Id = 0, UserName = "UserName3", Email = "Email3", Password = "Password3" },
                    new Admin { Id = 0, UserName = "UserName4", Email = "Email4", Password = "Password4" },
                    new Admin { Id = 0, UserName = "UserName5", Email = "Email5", Password = "Password5" },
                    new Admin { Id = 0, UserName = "UserName6", Email = "Email6", Password = "Password6" }
                );
            context.Categories.AddRange(
                    new Category { Id = 0, CategoryName = "Category1", DateTime = DateTime.Parse("06-04-2020") },
                    new Category { Id = 0, CategoryName = "Category2", DateTime = DateTime.Parse("06-04-2020") },
                    new Category { Id = 0, CategoryName = "Category3", DateTime = DateTime.Parse("06-04-2020") },
                    new Category { Id = 0, CategoryName = "Category4", DateTime = DateTime.Parse("06-04-2020") },
                    new Category { Id = 0, CategoryName = "Category5", DateTime = DateTime.Parse("06-04-2020") },
                    new Category { Id = 0, CategoryName = "Category6", DateTime = DateTime.Parse("06-04-2020") }
                );
            context.MetaDatas.AddRange(
                    new MetaData { Id = 0, CartId = 1, ProductId = 1, UserId = 1 },
                    new MetaData { Id = 0, CartId = 2, ProductId = 2, UserId = 2 },
                    new MetaData { Id = 0, CartId = 3, ProductId = 3, UserId = 3 },
                    new MetaData { Id = 0, CartId = 4, ProductId = 4, UserId = 4 },
                    new MetaData { Id = 0, CartId = 5, ProductId = 5, UserId = 5 },
                    new MetaData { Id = 0, CartId = 6, ProductId = 6, UserId = 6 }
                );
            context.Products.AddRange(
                    new Product { Id = 0, ProductName = "Product1", ProductCategory = "Category1", Company = "Company1", Price = 100, Quantity = 10, Description = "Description1", ImageUrl = "ImageUrl1", DateTime = DateTime.Parse("04-06-2020"), Count = 1 },
                    new Product { Id = 0, ProductName = "Product2", ProductCategory = "Category2", Company = "Company2", Price = 200, Quantity = 20, Description = "Description2", ImageUrl = "ImageUrl2", DateTime = DateTime.Parse("04-06-2020"), Count = 2 },
                    new Product { Id = 0, ProductName = "Product3", ProductCategory = "Category3", Company = "Company3", Price = 300, Quantity = 30, Description = "Description3", ImageUrl = "ImageUrl3", DateTime = DateTime.Parse("04-06-2020"), Count = 3 },
                    new Product { Id = 0, ProductName = "Product4", ProductCategory = "Category4", Company = "Company4", Price = 400, Quantity = 40, Description = "Description4", ImageUrl = "ImageUrl4", DateTime = DateTime.Parse("04-06-2020"), Count = 4 },
                    new Product { Id = 0, ProductName = "Product5", ProductCategory = "Category5", Company = "Company5", Price = 500, Quantity = 50, Description = "Description5", ImageUrl = "ImageUrl5", DateTime = DateTime.Parse("04-06-2020"), Count = 5 },
                    new Product { Id = 0, ProductName = "Product6", ProductCategory = "Category6", Company = "Company6", Price = 600, Quantity = 60, Description = "Description6", ImageUrl = "ImageUrl6", DateTime = DateTime.Parse("04-06-2020"), Count = 6 }
                );
            context.SaveChanges();
        }
    }
}
