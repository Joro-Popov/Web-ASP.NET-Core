﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models.ViewModels
{
    public class EventViewModel
    {
        [Required]
        [MinLength(10,ErrorMessage = "Name must be at least {1} characters long!")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Start field is not in valid date format!")]
        public string Start { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "End field is not in valid date format!")]
        public string End { get; set; }

        [Required]
        public string Place { get; set; }
    }
}
