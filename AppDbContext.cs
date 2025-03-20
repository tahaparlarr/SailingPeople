using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Domain;
using System.Reflection;

namespace SailingPeople;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public required virtual DbSet<Boat> Boats { get; set; }
    public required virtual DbSet<Category> Categories { get; set; }
    public required virtual DbSet<BoatImage> BoatImages { get; set; }
    public required virtual DbSet<Spec> Specs { get; set; }
    public required virtual DbSet<Facility> Facilities { get; set; }
    public required virtual DbSet<BoatSpec> BoatSpecs { get; set; }

}
