using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.API.Data
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private async static Task SeedUsers(UserManager<IdentityUser> userManager) 
        {
            if (await userManager.FindByEmailAsync("admin@bookstore.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Admin",
                    Email = "admin@bookstore.com"
                };
                var result = await userManager.CreateAsync(user,"P@$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }

            if (await userManager.FindByEmailAsync("cannonjw@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "cannonjw",
                    Email = "cannonjw@gmail.com"
                };
                var result = await userManager.CreateAsync(user,"P@$$w0rd");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
            }

        }

        private async static Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if(! await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                await roleManager.CreateAsync(role);
            }

            if(! await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };
                await roleManager.CreateAsync(role);
            }

        }
    }
}