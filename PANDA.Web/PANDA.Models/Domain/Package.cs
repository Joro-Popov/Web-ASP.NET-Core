using System;
using PANDA.Models.Domain.Enumerations;

namespace PANDA.Models.Domain
{
    public class Package
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public Status Status { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public int RecipientId { get; set; }

        public virtual ApplicationUser Recipient { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
