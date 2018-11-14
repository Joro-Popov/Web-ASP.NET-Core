using System;
using System.Collections.Generic;
using System.Text;

namespace CHUSHKA.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
