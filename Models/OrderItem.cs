using System.ComponentModel.DataAnnotations;

namespace AngularIS4MySQL.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}