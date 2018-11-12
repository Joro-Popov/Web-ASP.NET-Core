using System;
using System.Collections.Generic;
using System.Text;

namespace PANDA.Models.ViewModels
{
    public class ShippedViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string EstimatedDeliveryDate { get; set; }

        public string Recipient { get; set; }
    }
}
