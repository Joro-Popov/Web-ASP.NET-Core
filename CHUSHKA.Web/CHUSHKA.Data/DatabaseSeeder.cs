using System;
using System.Linq;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Identity;

namespace CHUSHKA.Data
{
    public static class DatabaseSeeder
    {
        public static void Seed(ChushkaDbContext dbContext, RoleManager<ApplicationUserRole> roleManager)
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
        private static void SeedRoles(RoleManager<ApplicationUserRole> roleManager)
        {
            SeedRole("Admin", roleManager);
            SeedRole("User", roleManager);
        }
        private static void SeedRole(string roleName, RoleManager<ApplicationUserRole> roleManager)
        {
            var role = roleManager.FindByNameAsync(roleName).GetAwaiter().GetResult();

            if (role != null) return;

            var result = roleManager
                .CreateAsync(new ApplicationUserRole() { Name = roleName, NormalizedName = roleName.ToUpper(), ConcurrencyStamp = Guid.NewGuid().ToString() }).GetAwaiter().GetResult();

            if (!result.Succeeded)
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
            }
        }
    }
}
