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
        [Key]
        [Display(Name = "Order")]
        public int OrderId  { get; set; }
        [Required]
        [Display(Name = "CSR")]
        public int CSRId { get; set; }
        public CSR CSR { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public int CustomerId  { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [Display(Name = "Date Placed")]
        public DateTime DatePlaced { get; set; }
        [Required]
        [Display(Name = "Date Due")]
        public DateTime DateDue { get; set; }
        [Required]
        [Display(Name = "Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }
        [Required]
        public bool Rush { get; set; }
        [Required]
        public bool Install { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
