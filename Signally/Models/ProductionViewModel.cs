using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Signally.Models
{
    public class ProductionViewModel
    {
        public Order Order { get; set; }

        public IEnumerable<OrderItem> OrderItem { get; set; }
    }
}
