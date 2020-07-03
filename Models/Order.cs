using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIS4MySQL.Models
{
    public class Order
    {
        public int id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
