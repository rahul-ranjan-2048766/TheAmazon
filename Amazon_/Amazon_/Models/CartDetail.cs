using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Models
{
    public class CartDetail
    {
        public Cart cart { get; set; }
        public Product product { get; set; }
        public User user { get; set; }
        //public List<Category> categories { get; set; }
    }
}
