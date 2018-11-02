using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Signally.Data;

namespace Signally.Models
{
    public class DetailsProductionViewModel
    {
        public int? OrderId { get; set; }
        public virtual List<OrderItem> OrderItemCollection { get; set; } = new List<OrderItem>();
    }
}
