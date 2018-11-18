using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int TotalTickets { get; set; }

        [Required]
        public decimal PricePerTicket { get; set; }
    }
}
