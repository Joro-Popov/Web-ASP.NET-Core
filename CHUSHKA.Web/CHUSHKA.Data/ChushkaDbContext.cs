using System.Threading;
using System.Threading.Tasks;
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
