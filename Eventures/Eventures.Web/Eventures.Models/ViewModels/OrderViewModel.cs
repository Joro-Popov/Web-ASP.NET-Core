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
        [Range(0, int.MaxValue)]
        public int TicketsCount { get; set; }
    }
}
