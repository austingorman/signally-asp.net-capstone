using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Signally.Data;

namespace Signally.Models
{
    public class CreateOrderViewModel
    {
        public Order order { get; set; }

        public List<SelectListItem> CSR { get; set; }
        public List<SelectListItem> Customer { get; set; }
        public List<SelectListItem> Status { get; set; }

        public CreateOrderViewModel(ApplicationDbContext context)
        {
            CSR = context.CSR.Select(CSR => new SelectListItem { Text = CSR.FirstName, Value = CSR.CSRId.ToString() }).ToList();
            Customer = context.Customer.Select(Customer => new SelectListItem { Text = Customer.FullName, Value = Customer.CustomerId.ToString() }).ToList();
            Status = context.Status.Select(Status => new SelectListItem { Text = Status.StatusName, Value = Status.StatusId.ToString() }).ToList();

            //CSR = context.CSR.ToList();
            //Customer = context.Customer.ToList();
            //Status = context.Status.ToList();
        }
    }
}
