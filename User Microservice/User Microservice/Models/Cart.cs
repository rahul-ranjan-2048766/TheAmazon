using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_Microservice.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
