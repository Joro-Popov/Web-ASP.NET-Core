using CHUSHKA.Models;
using CHUSHKA.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Data
{
    public class ChushkaDbContext : IdentityDbContext<ApplicationUser, ApplicationUserRole, int>
    {
        public ChushkaDbContext(DbContextOptions options) : base(options)
        {
        }

        public  ChushkaDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
