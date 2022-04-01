using System;
using Xunit;
using User_Microservice.Controllers;
using User_Microservice.Models;
using User_Microservice.Repositories;
using User_Microservice.Services;
using User_Microservice.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Moq;

namespace UserMicroservice.Tests
{
    public class UnitTests
    {
        private readonly IUserRepository userRepository;
        private readonly IUserService userService;
        private readonly UserController userController;
        private readonly IJwtAuthenticateManager jwtAuthenticateManager;
        private readonly ICartRepository cartRepository;
        private readonly ICartService cartService;

        static DbContextOptions<ApplicationDbContext> dbContextOptions;
        static string ConnectionString = @"Data Source=127.0.0.1\{sql2019},1433;Initial Catalog=AmazonDatabaseDummyDb;User ID=SA;Password=India46@$";
        static UnitTests() => dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(ConnectionString).Options;
        public UnitTests()
        {
            ApplicationDbContext context = new ApplicationDbContext(dbContextOptions);
            DummyDbInitializer dummy = new DummyDbInitializer();
            dummy.Seed(context);
            userRepository = new UserRepository(context);
            userService = new UserService(userRepository);
            userController = new UserController(userService);
            cartRepository = new CartRepository(context);
            cartService = new CartService(cartRepository);
        }

        // UserController

        [Fact]
        public void AddUser_UnitTest()
        {
            var result = userController.AddUser(new User 
                { 
                    Id = 0,
                    UserName = "UserName",
                    Name = "Name",
                    Email = "Email",
                    UserImage = "UserImage",
                    City = "City",
                    Password = "Password",
                    DateTime = DateTime.Parse("06-04-2020")
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddUser_NegativeTest()
        {
            var result = userController.AddUser(new User 
                { 
                    Id = 46,
                    Name = "Name46",
                    Email = "Email46",
                    UserName = "UserName46",
                    City = "City46",
                    UserImage = "UserImage46",
                    Password = "Password46",
                    DateTime = DateTime.Parse("06-04-2020")
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteUser_PositiveTest()
        {
            var result = userController.DeleteUser(6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteUser_NegativeTest()
        {
            var result = userController.DeleteUser(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetUserById_PositiveTest()
        {
            var result = userController.GetUserById(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetUserById_NegativeTest()
        {
            var result = userController.GetUserById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetUsers_PositiveTest()
        {
            var result = userController.GetUsers();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateUser_PositiveTest()
        {
            var getUser = userController.GetUserById(6);
            var result1 = getUser.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<User>().Subject;
            var putUser = userController.UpdateUser(result2);
            Assert.IsType<OkObjectResult>(putUser);
        }

        [Fact]
        public void UpdateUser_NegativeTest()
        {
            var getUser = userController.GetUserById(4);
            var result1 = getUser.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<User>().Subject;
            result2.Id = 0;
            var putUser = userController.UpdateUser(result2);
            Assert.IsType<BadRequestObjectResult>(putUser);
        }

        // AuthenticateController

        [Fact]
        public void Authenticate_Test()
        {
            Mock<IConfiguration> mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.Setup(x => x["JWT:UserSecret"]).Returns("FeCwssbBm37pbhnfGqKWhGzd7ya2beb63vTZ6ssFU2LyzrLaWNuhKWBspdM5RAVf6CbrcgcmD2Fkr2y8");
            IJwtAuthenticateManager jwtAuthenticateManager = new JwtAuthenticateManager(userService, mockConfiguration.Object);
            AuthenticateController authenticateController = new AuthenticateController(jwtAuthenticateManager, cartService);
            var result = authenticateController.Authenticate(new UserCred 
                { 
                    UserName = "UserName4",
                    Password = "Password4"
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Authenticate_Negative_Unit_Test()
        {
            Mock<IConfiguration> mock = new Mock<IConfiguration>();
            mock.Setup(x => x["JWT:UserSecret"]).Returns("FeCwssbBm37pbhnfGqKWhGzd7ya2beb63vTZ6ssFU2LyzrLaWNuhKWBspdM5RAVf6CbrcgcmD2Fkr2y8");
            IJwtAuthenticateManager jwtAuthenticateManager = new JwtAuthenticateManager(userService, mock.Object);
            AuthenticateController authenticateController = new AuthenticateController(jwtAuthenticateManager, cartService);
            var result = authenticateController.Authenticate(new UserCred 
            { 
                UserName = "UserName46",
                Password = "Password46"
            });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteCartsByUserId_PositiveTest()
        {
            Mock<IConfiguration> mock = new Mock<IConfiguration>();
            mock.Setup(x => x["JWT:SecretKey"]).Returns("FeCwssbBm37pbhnfGqKWhGzd7ya2beb63vTZ6ssFU2LyzrLaWNuhKWBspdM5RAVf6CbrcgcmD2Fkr2y8");
            IJwtAuthenticateManager jwtAuthenticateManager = new JwtAuthenticateManager(userService, mock.Object);
            AuthenticateController authenticateController = new AuthenticateController(jwtAuthenticateManager, cartService);
            var result = authenticateController.DeleteCartsByUserId(4);
            Assert.IsType<OkObjectResult>(result);
        }

        // CartController

        [Fact]
        public void AddCart_PositiveTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.AddCart(new Cart 
                { 
                    DeliveryAddress = "Address46",
                    ProductId = 46,
                    UserId = 46,
                    NetPrice = 4600,
                    QuantityOrdered = 64,
                    Status = "Status46",
                    DateTime = DateTime.Parse("06-04-2020")
                });
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void AddCart_NegativeTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.AddCart(new Cart 
                { 
                    DeliveryAddress = "Address46",
                    DateTime = DateTime.Parse("06-04-2020"),
                    NetPrice = 4600,
                    ProductId = 46,
                    QuantityOrdered = 64,
                    Status = "Status46",
                    UserId = 46,
                    Id = 46
                });
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteCart_PositiveTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.DeleteCart(6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void DeleteCart_NegativeTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.DeleteCart(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetCartById_PositiveTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.GetCartById(4);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetCartById_NegativeTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.GetCartById(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetCarts_PositiveTest()
        {
            CartController cartController = new CartController(cartService);
            var result = cartController.GetCarts();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateCart_PositiveTest()
        {
            CartController cartController = new CartController(cartService);
            var getCart = cartController.GetCartById(6);
            var result1 = getCart.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Cart>().Subject;
            var putCart = cartController.UpdateCart(result2);
            Assert.IsType<OkObjectResult>(putCart);
        }

        [Fact]
        public void UpdateCart_NegativeTest()
        {
            CartController cartController = new CartController(cartService);
            var getCart = cartController.GetCartById(4);
            var result1 = getCart.Should().BeOfType<OkObjectResult>().Subject;
            var result2 = result1.Value.Should().BeOfType<Cart>().Subject;
            result2.Id = 0;
            var putCart = cartController.UpdateCart(result2);
            Assert.IsType<BadRequestObjectResult>(putCart);
        }

        // UpdateCartController

        [Fact]
        public void UpdateCartOfUpdateCartController_PositiveTest()
        {
            UpdateCartController updateCartController = new UpdateCartController(cartService);
            var result = updateCartController.UpdateCart(6);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void UpdateCartOfUpdateCartController_NegativeTest()
        {
            UpdateCartController updateCartController = new UpdateCartController(cartService);
            var result = updateCartController.UpdateCart(46);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void DeleteCartsByProductId_PositiveTest()
        {
            UpdateCartController updateCartController = new UpdateCartController(cartService);
            var result = updateCartController.DeleteCartsByProductId(4);
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
