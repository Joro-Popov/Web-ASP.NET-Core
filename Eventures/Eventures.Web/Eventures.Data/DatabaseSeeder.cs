using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Data
{
    public class DatabaseSeeder
    {
        public static void Seed(EventuresDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (roleManager == null)
            {
                throw new ArgumentNullException(nameof(roleManager));
            }

            SeedRoles(roleManager);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            SeedRole("Admin", roleManager);
            SeedRole("User", roleManager);
        }
        private static void SeedRole(string roleName, RoleManager<IdentityRole> roleManager)
        {
            var role = roleManager.FindByNameAsync(roleName).GetAwaiter().GetResult();

            if (role != null) return;

            var result = roleManager
                .CreateAsync(new IdentityRole() { Name = roleName, NormalizedName = roleName.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() }).GetAwaiter().GetResult();

            if (!result.Succeeded)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
            }
        }
    }
}
