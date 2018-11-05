using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Signally.Models
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string TypeName { get; set; }
        [Required]
        [Display(Name = "Unit Price")]
        public decimal PricePerUnit { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }

    }
}
