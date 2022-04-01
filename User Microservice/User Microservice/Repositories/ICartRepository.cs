using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace User_Microservice.Repositories
{
    public interface ICartRepository
    {
        public void AddCart(Cart cart);
        public void DeleteCart(int id);
        public Cart GetCartById(int id);
        public List<Cart> GetCarts();
        public void UpdateCart(Cart cart);
    }
}
