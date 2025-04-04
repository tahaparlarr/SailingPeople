using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SailingPeople;
using SailingPeople.Domain;
using SailingPeople.Models;
using SailingPeople.Resources;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization(config => config.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResources)));

builder.Services
    .AddLocalization(config =>
    {
        config.ResourcesPath = "Resources";
    });

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
    });

builder.Services.AddAuthorization();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    // option.UseLazyLoadingProxies();

});

builder.Services.AddAutoMapper(config =>
{
    config.CreateMap<Boat, BoatDto>().ReverseMap();
    config.CreateMap<BoatImage, BoatImageDto>().ReverseMap();
    config.CreateMap<BoatSpec, BoatSpecDto>().ReverseMap();
    config.CreateMap<Spec, SpecDto>().ReverseMap();
    config.CreateMap<Category, CategoryDto>().ReverseMap();
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

var supportedCultures = new[] { "en", "tr" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();
    SeedData.Initialize(scope.ServiceProvider);
}

app.Run();
