using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace UserMicroservice.Tests
{
    public class DummyDbInitializer
    {
        public DummyDbInitializer() { }
        public void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Users.AddRange(
                    new User { UserName = "UserName1", UserImage = "UserImage1", Name = "Name1", Email = "Email1", City = "City1", Password = "Password1", DateTime = DateTime.Now },
                    new User { UserName = "UserName2", UserImage = "UserImage2", Name = "Name2", Email = "Email2", City = "City2", Password = "Password2", DateTime = DateTime.Now },
                    new User { UserName = "UserName3", UserImage = "UserImage3", Name = "Name3", Email = "Email3", City = "City3", Password = "Password3", DateTime = DateTime.Now },
                    new User { UserName = "UserName4", UserImage = "UserImage4", Name = "Name4", Email = "Email4", City = "City4", Password = "Password4", DateTime = DateTime.Now },
                    new User { UserName = "UserName5", UserImage = "UserImage5", Name = "Name5", Email = "Email5", City = "City5", Password = "Password5", DateTime = DateTime.Now },
                    new User { UserName = "UserName6", UserImage = "UserImage6", Name = "Name6", Email = "Email6", City = "City6", Password = "Password6", DateTime = DateTime.Now }
                );
            context.Carts.AddRange(
                    new Cart { UserId = 1, ProductId = 1, NetPrice = 100, QuantityOrdered = 10, DeliveryAddress = "Address1", Status = "Status1", DateTime = DateTime.Parse("04-06-2020") },
                    new Cart { UserId = 2, ProductId = 2, NetPrice = 200, QuantityOrdered = 20, DeliveryAddress = "Address2", Status = "Status2", DateTime = DateTime.Parse("04-06-2020") },
                    new Cart { UserId = 3, ProductId = 3, NetPrice = 300, QuantityOrdered = 30, DeliveryAddress = "Address3", Status = "Status3", DateTime = DateTime.Parse("04-06-2020") },
                    new Cart { UserId = 4, ProductId = 4, NetPrice = 400, QuantityOrdered = 40, DeliveryAddress = "Address4", Status = "Status4", DateTime = DateTime.Parse("04-06-2020") },
                    new Cart { UserId = 5, ProductId = 5, NetPrice = 500, QuantityOrdered = 50, DeliveryAddress = "Address5", Status = "Status5", DateTime = DateTime.Parse("04-06-2020") },
                    new Cart { UserId = 6, ProductId = 6, NetPrice = 600, QuantityOrdered = 60, DeliveryAddress = "Address6", Status = "Status6", DateTime = DateTime.Parse("04-06-2020") }
                );
            context.SaveChanges();
        }
    }
}
