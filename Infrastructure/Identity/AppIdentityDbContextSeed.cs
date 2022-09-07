using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Dominik",
                    Email = "dominik@test.com",
                    UserName = "dominik@test.com",
                    Address = new Address
                    {
                        FirstName = "Dominik",
                        LastName = "Malinowski",
                        Street = "Keniga 6",
                        City = "Warszawa",
                        ZipCode = "12-222"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}