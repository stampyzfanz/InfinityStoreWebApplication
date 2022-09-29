using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public enum Category
    {
        Pokemon,
        [Display(Name = "Action figures")]
        ActionFigure,
        [Display(Name = "Collectors boxes")]
        CollectorBox
    }
    public class Product
    {
        public int ProductId { get; set; }
        public int AttributesId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;
        // decimal is accepted datatype for financial calculations https://stackoverflow.com/a/50689058
        // Microsoft's docs agree https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        [Required]
        [Range(0, 100000000)]
        public decimal PurchasePrice { get; set; }
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        [Required]
        [Range(0, 100000000)]
        public decimal SalePrice { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public List<Image> Images { get; set; } = new List<Image>();
        [Required]
        public Category Category { get; set; }
        [Required]
        public Attributes? Attributes { get; set; }
        [Required]
        public List<ProductStock> ProductStockList { get; set; } = new List<ProductStock>();
    }
}
