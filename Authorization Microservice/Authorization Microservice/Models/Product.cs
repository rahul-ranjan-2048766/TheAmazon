using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authorization_Microservice.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
