using System;
using System.Collections.Generic;
using System.Text;

namespace CHUSHKA.Models.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public string Customer { get; set; }

        public string Product { get; set; }

        public string OrderedOn { get; set; }

    }
}
