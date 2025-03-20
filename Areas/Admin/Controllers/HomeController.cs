using Microsoft.AspNetCore.Mvc;
using SailingPeople.Models;
using SailingPeople.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp.Formats.Webp;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Migrations;
using SixLabors.ImageSharp.Metadata.Profiles.Iptc;

namespace SailingPeople.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController(AppDbContext dbContext) : Controller
{
    public async Task<IActionResult> Index()
    {
        var boats = (await dbContext.Boats.ToListAsync()).Select(p => new BoatDto(p));

        return View(boats);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var specs = dbContext.Specs.ToList();
        ViewBag.Specs = specs;

        var facility = dbContext.Facilities.ToList();
        ViewBag.Facility = facility;

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
            SeptemberPrice = model.SeptemberPrice,
        };

        for (int i = 0; i < model.SpecId.Count(); i++)
            boat.BoatSpecs.Add(new BoatSpec { 
                SpecId = model.SpecId[i],
                ValueTr = model.SpecValue[i],
                ValueEn = model.SpecValue[i] });

        if (model.ImageFile != null && model.ImageFile.Length > 0)
        {
            using var image = await Image.LoadAsync(model.ImageFile!.OpenReadStream());
            image.Mutate(p => p.Resize(new ResizeOptions { Mode = ResizeMode.Crop, Size = new Size(800, 800) }));
            boat.Image = image.ToBase64String(WebpFormat.Instance);
        }

        if (model.Images != null && model.Images.Count > 0)
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
    public async Task<IActionResult> Delete(Guid Id)
    {

        await dbContext.Boats.Where(p => p.Id == Id).ExecuteDeleteAsync();

        return RedirectToAction("Index");
    }
}