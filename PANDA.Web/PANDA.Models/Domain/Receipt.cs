using System;

namespace PANDA.Models.Domain
{
    public class Receipt
    {
        public int Id { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; }

        public int RecipientId { get; set; }

        public virtual ApplicationUser Recipient { get; set; }

        public int PackageId { get; set; }

        public virtual Package Package { get; set; }
    }
}
