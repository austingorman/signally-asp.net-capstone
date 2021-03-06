﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Signally.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string StatusName { get; set; }
    }
}
