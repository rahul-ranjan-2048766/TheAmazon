using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;
using User_Microservice.Repositories;

namespace User_Microservice.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository repository;
        public CartService(ICartRepository cartRepository)
        {
            repository = cartRepository;
        }

        public void AddCart(Cart cart)
        {
            repository.AddCart(cart);
        }

        public void DeleteCart(int id)
        {
            repository.DeleteCart(id);
        }

        public Cart GetCartById(int id)
        {
            return repository.GetCartById(id);
        }

        public List<Cart> GetCarts()
        {
            return repository.GetCarts();
        }

        public void UpdateCart(Cart cart)
        {
            repository.UpdateCart(cart);
        }
    }
}
