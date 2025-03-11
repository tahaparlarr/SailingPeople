using Microsoft.AspNetCore.Mvc;
using SailingPeople.Models;
using SailingPeople.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp.Formats.Webp;

namespace SailingPeople.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController(AppDbContext dbContext) : Controller
{
    // Index GET
    public IActionResult Index()
    {
        return View();
    }

    // Create GET
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(dbContext.Categories.ToList().Select(p => new CategoryDto(p)), "Id", "LocalizedName");
        return View(new BoatDto());
    }

    // Create POST
    [HttpPost]
    public async Task<IActionResult> Create(BoatDto model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var boat = new Boat
        {
            Id = model.Id,
            Name = model.Name!,
            CategoryId = model.CategoryId,
            Width = model.Width ?? 0,
            Length = model.Length ?? 0,
            Cabin = model.Cabin ?? 0,
            Guest = model.Guest ?? 0
        };

        if (model.Image != null)
        {
            using var image = await Image.LoadAsync(model.Image!.OpenReadStream());
            image.Mutate(p => p.Resize(new ResizeOptions { Mode = ResizeMode.Crop, Size = new Size(800, 800) }));
            boat.Image = image.ToBase64String(WebpFormat.Instance);
        }

        if (model.Images != null)
        {
            foreach (var item in model.Images)
            {
                using var image = await Image.LoadAsync(item.OpenReadStream());
                image.Mutate(p => p.Resize(new ResizeOptions { Mode = ResizeMode.Crop, Size = new Size(800, 800) }));
                boat.BoatImages.Add(new BoatImage { Image = image.ToBase64String(WebpFormat.Instance) });
            }
        }

        dbContext.Boats.Add(boat);
        dbContext.SaveChanges();

        return RedirectToAction("Index");
    }


}
