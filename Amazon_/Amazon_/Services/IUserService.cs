using Amazon_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Services
{
    public interface IUserService
    {
        public User GetUserById(int UserId);
        public List<User> GetUsers();
        public List<MetaData> GetCartMetaData();
        public void AddMeta(MetaData meta, string adminToken);
        public string AddUser(User user);
        public Tuple<string, int> UpdateUser(User userData, string userToken);
        public void DeleteUser(int UserId);
        public Tuple<Response, string> AuthenticateUser(UserCred userCred);
        public List<Cart> GetCarts();
        public Cart GetCartById(int CartId);
        public string AddCart(Cart cart, string userToken);
        public void DeleteCart(int CartId, string userToken);
        public void ReducePurchasedProductQuantity(int ProductId, int QuantityOrdered);
        public void IncreaseQuantityAfterCancellation(int ProductId, int QuantityOrdered);
        public void UpdateCountAfterCancellation(int ProductId);
        public void DeleteCartsByProductId(int ProductId);
        public void DeleteCartsByUserId(int UserId);
    }
}
