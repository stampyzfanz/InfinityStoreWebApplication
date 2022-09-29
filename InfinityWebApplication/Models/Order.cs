using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public List<ProductOrder> ProductOrderList { get; set; } = new List<ProductOrder>();
        [Required]
        public Store? Store { get; set; }
        public int StoreId { get; set; }
        [Required]
        [Range(0, 10000000)]
        public DateTime Timestamp { get; set; }
    }
}