using System;
using System.Collections.Generic;
using System.Text;

namespace PANDA.Models.ViewModels
{
    public class CreatePackageViewModel
    {
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public string Recipient { get; set; }
    }
}
