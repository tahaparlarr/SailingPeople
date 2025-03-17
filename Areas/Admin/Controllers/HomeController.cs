using Microsoft.AspNetCore.Mvc;
using SailingPeople.Models;
using SailingPeople.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp.Formats.Webp;
using Microsoft.EntityFrameworkCore;

namespace SailingPeople.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Specs = dbContext.Specs.ToList();
        ViewBag.Categories = new SelectList(dbContext.Categories.ToList().Select(p => new CategoryDto(p)), "Id", "LocalizedName");
        return View(new BoatDto());
    }

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
            Guest = model.Guest ?? 0,
            Code = model.Code,
            MayToOctoberPrice = model.MayToOctoberPrice,
            JunePrice = model.JunePrice,
            JulyToAugustPrice = model.JulyToAugustPrice,
            SeptemberPrice = model.SeptemberPrice
        };

        if (model.Image != null)
        {
            using var image = await Image.LoadAsync(model.ImageFile!.OpenReadStream());
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

    [HttpGet]
    public async Task<IActionResult> Delete()
    {
        var boats = await dbContext.Boats.Select(p => new BoatDto(p)).ToListAsync();

        return View(boats);
    }

    //[HttpPost]
    //public async Task<IActionResult> Delete(Guid Id)
    //{

    //    var boat = await dbContext.Boats.FindAsync(Id);

    //    if (boat == null)
    //    {
    //        return NotFound();
    //    }

    //    dbContext.Boats.Remove(boat);
    //    dbContext.SaveChanges();

    //    return RedirectToAction("Index");
    //}
}
