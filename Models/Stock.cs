using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIS4MySQL.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
