﻿using System.ComponentModel.DataAnnotations;

namespace AngularIS4MySQL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory productCategory { get; set; }
    }
}