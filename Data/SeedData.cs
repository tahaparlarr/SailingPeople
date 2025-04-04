using Microsoft.EntityFrameworkCore;
using SailingPeople;
using SailingPeople.Domain;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        if (!context.Users.Any())
        {
            context.Users.Add(new User
            {
                Username = "admin",
                Password = "!Cmos1234"
            });

            context.SaveChanges();
        }
    }
}
