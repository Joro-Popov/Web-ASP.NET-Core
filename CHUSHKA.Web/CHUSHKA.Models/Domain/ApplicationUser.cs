using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CHUSHKA.Models.Domain
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; }

        public virtual ICollection<Order> UserOrders { get; set; } = new HashSet<Order>();
    }
}
