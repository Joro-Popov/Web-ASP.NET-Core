using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventures.Models.ViewModels
{
    public class OrderViewModel
    {
        public Guid EventId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The minimum count is 1!")]
        public int? TicketsCount { get; set; }
    }
}
