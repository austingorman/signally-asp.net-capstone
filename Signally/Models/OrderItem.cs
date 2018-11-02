using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Signally.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [Required]
        [Display(Name = "Type")]
        public int TypeId { get; set; }
        public Type Type { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Width { get; set; }
        public decimal Price { get; set; }
    }
}
