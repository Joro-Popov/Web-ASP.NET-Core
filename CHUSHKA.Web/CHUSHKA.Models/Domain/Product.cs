﻿using System.Collections.Generic;
using CHUSHKA.Models.Enumerations;

namespace CHUSHKA.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        public virtual ICollection<Order> ProductOrders { get; set; } = new HashSet<Order>();
    }
}
