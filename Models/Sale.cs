using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIS4MySQL.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
    }
}
