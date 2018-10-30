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
        [Display(Name = "CSR")]
        public int CSRId { get; set; }
        public CSR CSR { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public int CustomerId  { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [Display(Name = "DatePlaced")]
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
        [Required]
        public double Price { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
