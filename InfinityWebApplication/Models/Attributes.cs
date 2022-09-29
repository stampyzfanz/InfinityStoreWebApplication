using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class Attributes
    {
        public int AttributesId { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? Franchise { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? Brand { get; set; }
        public bool? Articulation { get; set; }
        // note that its called Collectibles Manfacturer
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? CollectiblesManufacturer { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? FigureType { get; set; }
        public bool? ChanceOfAChase { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? Finish { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? Height { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string? PopVinylType { get; set; }
    }


    public class Main
    {
        private class ActionFigureAttributes
        {
            string? Franchise { get; set; }
            string? Brand { get; set; }
            bool? Articulation { get; set; }
            // note that its called Collectibles Manfacturer
            string? CollectiblesManufacturer { get; set; }
            string? FigureType { get; set; }
        }

        private class CollectorBoxAttributes
        {
            string? Franchise { get; set; }
            bool? ChanceOfAChase { get; set; }
        }

        private class PokemonAttributes
        {
            string? Finish { get; set; }
            string? Height { get; set; }
            string? PopVinylType { get; set; }
        }

        public static readonly Dictionary<Category, Type> CategoryAttributes
                    = new Dictionary<Category, Type>
                {
                    { Category.Pokemon, typeof(PokemonAttributes) },
                    { Category.ActionFigure, typeof(ActionFigureAttributes) },
                    { Category.CollectorBox, typeof(CollectorBoxAttributes) },
                };
    }
}