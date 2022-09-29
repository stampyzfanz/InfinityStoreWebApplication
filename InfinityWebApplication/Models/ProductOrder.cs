using System;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public Product? Product { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(0, 50000)]
        public int Quantity { get; set; }
        public Order? Order { get; set; }
        public int OrderId { get; set; }
    }
}