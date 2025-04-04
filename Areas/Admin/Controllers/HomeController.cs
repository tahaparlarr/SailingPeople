using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Domain;
using SailingPeople.Models;
using SixLabors.ImageSharp.Formats.Webp;

namespace SailingPeople.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class HomeController(AppDbContext dbContext, IMapper mapper) : Controller
{
    public async Task<IActionResult> Index()
    {
        var boats = (await dbContext.Boats.ToListAsync()).Select(p => mapper.Map<BoatDto>(p));

        return View(boats);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var specs = dbContext.Specs.ToList();
        ViewBag.Specs = specs;

        var facility = dbContext.Facilities.ToList();
        ViewBag.Facility = facility;

        ViewBag.Categories = new SelectList(dbContext.Categories.ToList().Select(p => mapper.Map<CategoryDto>(p)), "Id", "LocalizedName");
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
            boat.BoatSpecs.Add(new BoatSpec
            {
                SpecId = model.SpecId[i],
                ValueTr = model.SpecValue[i],
                ValueEn = model.SpecValue[i]
            });

        if (model.FacilityId != null && model.FacilityId.Any())
        {
            var selectedFacilities = dbContext.Facilities
                .Where(p => model.FacilityId.Contains(p.Id))
                .ToList();

            foreach (var facility in selectedFacilities)
            {
                boat.Facilities.Add(facility);
            }
        }

        if (model.ImageFile != null && model.ImageFile.Length > 0)
        {
            using var image = await Image.LoadAsync(model.ImageFile!.OpenReadStream());
            image.Mutate(p => p.Resize(new ResizeOptions { Mode = ResizeMode.Crop, Size = new Size(1024, 1024) }));
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

    [HttpGet]
    public async Task<IActionResult> Edit(Guid Id)
    {
        var boat = await dbContext.Boats
            .Include(b => b.Facilities)
            .Include(b => b.BoatSpecs)
            .Include(b => b.BoatImages)
            .FirstOrDefaultAsync(b => b.Id == Id);

        if (boat == null)
            return NotFound();

        var model = new BoatDto
        {
            Id = boat.Id,
            Name = boat.Name,
            CategoryId = boat.CategoryId,
            Width = boat.Width,
            Length = boat.Length,
            Cabin = boat.Cabin,
            Guest = boat.Guest,
            Code = boat.Code,
            MayToOctoberPrice = boat.MayToOctoberPrice,
            JunePrice = boat.JunePrice,
            JulyToAugustPrice = boat.JulyToAugustPrice,
            SeptemberPrice = boat.SeptemberPrice,
            FacilityId = boat.Facilities.Select(f => f.Id).ToList()
        };

        ViewBag.Specs = dbContext.Specs.ToList();
        ViewBag.Facility = dbContext.Facilities.ToList();
        ViewBag.Categories = new SelectList(
            dbContext.Categories.ToList().Select(p => mapper.Map<CategoryDto>(p)),
            "Id",
            "LocalizedName"
        );

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(BoatDto model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Specs = dbContext.Specs.ToList();
            ViewBag.Facility = dbContext.Facilities.ToList();
            ViewBag.Categories = new SelectList(
                dbContext.Categories.ToList().Select(p => mapper.Map<CategoryDto>(p)),
                "Id",
                "LocalizedName"
            );

            return View(model);
        }

        var boat = await dbContext.Boats
            .Include(b => b.BoatSpecs)
            .Include(b => b.Facilities)
            .Include(b => b.BoatImages)
            .FirstOrDefaultAsync(b => b.Id == model.Id);

        if (boat == null)
            return NotFound();

        boat.Name = model.Name!;
        boat.CategoryId = model.CategoryId;
        boat.Width = model.Width ?? 0;
        boat.Length = model.Length ?? 0;
        boat.Cabin = model.Cabin ?? 0;
        boat.Guest = model.Guest ?? 0;
        boat.Code = model.Code;
        boat.MayToOctoberPrice = model.MayToOctoberPrice;
        boat.JunePrice = model.JunePrice;
        boat.JulyToAugustPrice = model.JulyToAugustPrice;
        boat.SeptemberPrice = model.SeptemberPrice;

        boat.BoatSpecs.Clear();

        if (model.SpecId != null && model.SpecValue != null)
        {
            for (int i = 0; i < model.SpecId.Count(); i++)
            {
                boat.BoatSpecs.Add(new BoatSpec
                {
                    SpecId = model.SpecId[i],
                    ValueTr = model.SpecValue[i],
                    ValueEn = model.SpecValue[i]
                });
            }
        }

        boat.Facilities.Clear();
        if (model.FacilityId != null && model.FacilityId.Any())
        {
            var selectedFacilities = dbContext.Facilities
                .Where(f => model.FacilityId.Contains(f.Id))
                .ToList();

            foreach (var facility in selectedFacilities)
            {
                boat.Facilities.Add(facility);
            }
        }

        if (model.ImageFile != null && model.ImageFile.Length > 0)
        {
            using var image = await Image.LoadAsync(model.ImageFile.OpenReadStream());
            image.Mutate(p => p.Resize(new ResizeOptions
            {
                Mode = ResizeMode.Crop,
                Size = new Size(1024, 1024)
            }));
            boat.Image = image.ToBase64String(WebpFormat.Instance);
        }

        if (model.Images != null && model.Images.Count > 0)
        {
            foreach (var file in model.Images)
            {
                using var image = await Image.LoadAsync(file.OpenReadStream());
                image.Mutate(p => p.Resize(new ResizeOptions
                {
                    Mode = ResizeMode.Crop,
                    Size = new Size(800, 800)
                }));
                boat.BoatImages.Add(new BoatImage
                {
                    Image = image.ToBase64String(WebpFormat.Instance)
                });
            }
        }

        await dbContext.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}




