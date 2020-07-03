using System.ComponentModel.DataAnnotations;

namespace AngularIS4MySQL.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}