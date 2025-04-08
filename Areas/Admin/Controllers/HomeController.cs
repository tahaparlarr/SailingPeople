using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Domain;
using SailingPeople.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

namespace SailingPeople.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IMapper mapper;

        public HomeController(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var boats = await dbContext.Boats
                .Include(p => p.Category)
                .ToListAsync();
            var boatDtos = boats.Select(b => mapper.Map<BoatDto>(b)).ToList();
            return View(boatDtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PopulateDropdowns();

            return View(new BoatDto());
        }

        private void PopulateDropdowns()
        {
            ViewBag.Categories = new SelectList(dbContext.Categories.ToList(), "Id", "LocalizedName");
            ViewBag.Specs = dbContext.Specs.ToList();
            ViewBag.Facility = dbContext.Facilities.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BoatDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(dbContext.Categories.ToList(), "Id", "LocalizedName");
                ViewBag.Specs = dbContext.Specs.ToList();
                ViewBag.Facility = dbContext.Facilities.ToList();
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

            if (model.SpecId != null && model.SpecValue != null)
            {
                for (int i = 0; i < model.SpecId.Count; i++)
                {
                    boat.BoatSpecs.Add(new BoatSpec
                    {
                        SpecId = model.SpecId[i],
                        ValueTr = model.SpecValue[i],
                        ValueEn = model.SpecValue[i]
                    });
                }
            }

            if (model.FacilityId != null && model.FacilityId.Any())
            {
                var selectedFacilities = await dbContext.Facilities
                    .Where(f => model.FacilityId.Contains(f.Id))
                    .ToListAsync();
                foreach (var facility in selectedFacilities)
                {
                    boat.Facilities.Add(facility);
                }
            }

            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                using var coverImage = await Image.LoadAsync(model.ImageFile.OpenReadStream());
                coverImage.Mutate(p => p.Resize(new ResizeOptions
                {
                    Mode = ResizeMode.Crop,
                    Size = new Size(1024, 1024)
                }));
                boat.Image = coverImage.ToBase64String(WebpFormat.Instance);
            }

            if (model.Images != null && model.Images.Count > 0)
            {
                foreach (var file in model.Images)
                {
                    using var additionalImage = await Image.LoadAsync(file.OpenReadStream());
                    additionalImage.Mutate(p => p.Resize(new ResizeOptions
                    {
                        Mode = ResizeMode.Crop,
                        Size = new Size(800, 800)
                    }));
                    boat.BoatImages.Add(new BoatImage
                    {
                        Image = additionalImage.ToBase64String(WebpFormat.Instance)
                    });
                }
            }

            dbContext.Boats.Add(boat);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await dbContext.Boats
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 60)]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            PopulateDropdowns();

            var boat = await dbContext.Boats
                .Include(p => p.BoatImages)
                .Include(p => p.Facilities)
                .Include(p => p.Category)
                .Include(p => p.BoatSpecs)
                .ThenInclude(bs => bs.Spec)
                .SingleOrDefaultAsync(b => b.Id == id);

            if (boat == null)
            {
                return NotFound();
            }

            var model = mapper.Map<BoatDto>(boat);

            foreach (var spec in boat.BoatSpecs)
            {
                model.SpecId.Add(spec.SpecId);
                model.SpecValue.Add(spec.ValueTr);
            }

            foreach (var facility in boat.Facilities)
            {
                model.FacilityId.Add(facility.Id);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BoatDto model)
        {
            if (!ModelState.IsValid)
            {
                PopulateDropdowns();
                return View(model);
            }

            var boat = await dbContext.Boats
                .Include(p => p.BoatImages)
                .Include(p => p.Facilities)
                .Include(p => p.BoatSpecs)
                .SingleOrDefaultAsync(b => b.Id == model.Id);

            if (boat == null)
            {
                return NotFound();
            }

            boat.Name = model.Name!;
            boat.CategoryId = model.CategoryId;
            boat.Code = model.Code;
            boat.MayToOctoberPrice = model.MayToOctoberPrice;
            boat.JunePrice = model.JunePrice;
            boat.JulyToAugustPrice = model.JulyToAugustPrice;
            boat.SeptemberPrice = model.SeptemberPrice;
            boat.Width = model.Width ?? 0;
            boat.Length = model.Length ?? 0;
            boat.Guest = model.Guest ?? 0;
            boat.Cabin = model.Cabin ?? 0;

            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                using var coverImage = await Image.LoadAsync(model.ImageFile.OpenReadStream());
                coverImage.Mutate(p => p.Resize(new ResizeOptions
                {
                    Mode = ResizeMode.Crop,
                    Size = new Size(1024, 1024)
                }));
                boat.Image = coverImage.ToBase64String(WebpFormat.Instance);
            }

            if (model.Images != null && model.Images.Count > 0)
            {
                foreach (var file in model.Images)
                {
                    using var additionalImage = await Image.LoadAsync(file.OpenReadStream());
                    additionalImage.Mutate(p => p.Resize(new ResizeOptions
                    {
                        Mode = ResizeMode.Crop,
                        Size = new Size(800, 800)
                    }));
                    boat.BoatImages.Add(new BoatImage
                    {
                        Image = additionalImage.ToBase64String(WebpFormat.Instance)
                    });
                }
            }

            if (model.SpecId != null && model.SpecValue != null)
            {
                dbContext.BoatSpecs.RemoveRange(boat.BoatSpecs);

                for (int i = 0; i < model.SpecId.Count; i++)
                {
                    boat.BoatSpecs.Add(new BoatSpec
                    {
                        SpecId = model.SpecId[i],
                        ValueTr = model.SpecValue[i],
                        ValueEn = model.SpecValue[i]
                    });
                }
            }

            if (model.FacilityId != null)
            {
                boat.Facilities.Clear();

                var selectedFacilities = await dbContext.Facilities
                    .Where(f => model.FacilityId.Contains(f.Id))
                    .ToListAsync();
                foreach (var facility in selectedFacilities)
                {
                    boat.Facilities.Add(facility);
                }
            }

            dbContext.Boats.Update(boat);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
