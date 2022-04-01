using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}
