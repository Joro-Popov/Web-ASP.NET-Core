using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using PANDA.Models.Domain;
using System.Linq;

namespace PANDA.Data
{
    public static class InitializeDatabase
    {
        private static readonly List<ApplicationUserRole> Roles = new List<ApplicationUserRole>()
        {
            new ApplicationUserRole() {Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString()},
            new ApplicationUserRole() {Name = "User", NormalizedName = "USER", ConcurrencyStamp = Guid.NewGuid().ToString()}
        };

        public static void SeedData(PandaDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            dbContext.Database.EnsureCreated();
            AddRoles(dbContext);
        }

        private static void AddRoles(PandaDbContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                foreach (var role in Roles)
                {
                    dbContext.Roles.Add(role);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
