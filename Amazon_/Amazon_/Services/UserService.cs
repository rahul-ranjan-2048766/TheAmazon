using Amazon_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon_.Repositories;

namespace Amazon_.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUserById(int UserId)
        {
            return userRepository.GetUserById(UserId);
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public List<MetaData> GetCartMetaData()
        {
            return userRepository.GetCartMetaData();
        }

        public void AddMeta(MetaData meta, string adminToken)
        {
            userRepository.AddMeta(meta, adminToken);
        }

        public string AddUser(User user)
        {
            return userRepository.AddUser(user);
        }

        public Tuple<string, int> UpdateUser(User userData, string userToken)
        {
            return userRepository.UpdateUser(userData, userToken);
        }

        public void DeleteUser(int UserId)
        {
            userRepository.DeleteUser(UserId);
        }

        public Tuple<Response, string> AuthenticateUser(UserCred userCred)
        {
            return userRepository.AuthenticateUser(userCred);
        }

        public List<Cart> GetCarts()
        {
            return userRepository.GetCarts();
        }

        public Cart GetCartById(int CartId)
        {
            return userRepository.GetCartById(CartId);
        }

        public string AddCart(Cart cart, string userToken)
        {
            return userRepository.AddCart(cart, userToken);
        }

        public void DeleteCart(int CartId, string userToken)
        {
            userRepository.DeleteCart(CartId, userToken);
        }

        public void ReducePurchasedProductQuantity(int ProductId, int QuantityOrdered)
        {
            userRepository.ReducePurchasedProductQuantity(ProductId, QuantityOrdered);
        }

        public void IncreaseQuantityAfterCancellation(int ProductId, int QuantityOrdered)
        {
            userRepository.IncreaseQuantityAfterCancellation(ProductId, QuantityOrdered);
        }

        public void UpdateCountAfterCancellation(int ProductId)
        {
            userRepository.UpdateCountAfterCancellation(ProductId);
        }

        public void DeleteCartsByProductId(int ProductId)
        {
            userRepository.DeleteCartsByProductId(ProductId);
        }

        public void DeleteCartsByUserId(int UserId)
        {
            userRepository.DeleteCartsByUserId(UserId);
        }
    }
}
