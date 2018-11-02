using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Signally.Data;

namespace Signally.Models
{
    public class EditProductionViewModel
    {
        public Order Order { get; set; }
        public List<SelectListItem> Status { get; set; }
        public EditProductionViewModel(ApplicationDbContext context)
        {
            Status = context.Status.Select(Status => new SelectListItem { Text = Status.StatusName, Value = Status.StatusId.ToString() }).ToList();
        }
    }
}
