using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PANDA.Models.Domain
{
    public class ApplicationUser : IdentityUser<int>
    {
        public virtual ICollection<Package> Packages { get; set; } = new HashSet<Package>();

        public virtual ICollection<Receipt> Receipts { get; set; } = new HashSet<Receipt>();
    }
}
