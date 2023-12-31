﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("pay mode Id")]    
        public int Id { get; set; }

        [DisplayName("pay mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must  be between 3 and 50 characters")]
        public string Name { get; set; }
        [DisplayName("observation")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and  200 characters")]
        public string observation { get; set; }
        public string? Observation { get; internal set; }
    }
}
