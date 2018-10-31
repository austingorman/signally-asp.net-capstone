using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Signally.Data;

namespace Signally.Models
{
    public class EditOrderItemViewModel
    {
        public OrderItem OrderItem { get; set; }

        public List<SelectListItem> Type { get; set; }

        public EditOrderItemViewModel(ApplicationDbContext context)
        {
            Type = context.Type.Select(Type => new SelectListItem { Text = Type.TypeName, Value = Type.TypeId.ToString() }).ToList();
        }
    }
}
