using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace User_Microservice.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCart(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public void DeleteCart(int id)
        {
            var cart = _context.Carts.FirstOrDefault(x => x.Id == id);
            if (cart == null)
                throw new SystemException();
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }

        public Cart GetCartById(int id)
        {
            var cart = _context.Carts.FirstOrDefault(x => x.Id == id);
            if (cart == null)
                throw new SystemException();
            return cart;
        }

        public List<Cart> GetCarts()
        {
            return _context.Carts.ToList();
        }

        public void UpdateCart(Cart cart)
        {
            _context.Entry(cart).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
