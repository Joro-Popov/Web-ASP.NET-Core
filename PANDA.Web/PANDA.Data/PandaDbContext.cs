using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PANDA.Models;
using PANDA.Models.Domain;

namespace PANDA.Data
{
    public class PandaDbContext : IdentityDbContext<ApplicationUser, ApplicationUserRole, int>
    {
        public PandaDbContext()
        {
            
        }
        public PandaDbContext(DbContextOptions<PandaDbContext> options)
            : base(options)
        {

        }

        public new DbSet<ApplicationUser> Users { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Receipt> Receipts { get; set; }
        
    }
}
