using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Signally.Models
{
    public class Order
    {
        [Required]
        public int OrderId  { get; set; }
        [Required]
        public int CSRId { get; set; }
        [Required]
        public CSR CSR { get; set; }
        [Required]
        public int CustomerId  { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public DateTime DatePlaced { get; set; }
        [Required]
        public DateTime DateDue { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public bool Rush { get; set; }
        [Required]
        public bool Install { get; set; }
        [Required]
        public double Price { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
