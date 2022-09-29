using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        [Required]
        [MaxLength(200)]

        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Suburb { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string State { get; set; } = null!;
        [Required]
        // 0832 is a valid postcode which isn't a valid number
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string Postcode { get; set; } = null!;
        [Required]
        [Range(-180, 180)]
        public double Longitude { get; set; }
        [Required]
        [Range(-90, 90)]
        public double Latitude { get; set; }
        // as per https://stackoverflow.com/a/20497836, use suffix "List" since you can't pluralise "stock"
        [Required]
        public List<ProductStock> ProductStockList { get; set; } = new List<ProductStock>();

        // stock levels for products
    }
}