using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Signally.Data;

namespace Signally.Models
{
    public class ProductionViewModel
    {
        public Order Order { get; set; }
    }
}
