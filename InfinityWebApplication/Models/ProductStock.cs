using System;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class ProductStock
    {
        public int ProductStockId { get; set; }
        [Required]
        public Product? Product { get; set; }
        public int ProductId { get; set; }
        [Required]
        public Store? Store { get; set; }
        public int StoreId { get; set; }
        [Required]
        [Range(0, 10000000)]
        public int Quantity { get; set; }
    }
}