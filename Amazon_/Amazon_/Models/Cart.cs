using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int QuantityOrdered { get; set; }
        public double NetPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
    }
}
