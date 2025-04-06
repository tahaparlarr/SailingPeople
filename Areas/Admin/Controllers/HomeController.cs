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
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public HomeController(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var boats = await _dbContext.Boats.ToListAsync();
            var boatDtos = boats.Select(b => _mapper.Map<BoatDto>(b)).ToList();
            return View(boatDtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_dbContext.Categories.ToList(), "Id", "LocalizedName");
            ViewBag.Specs = _dbContext.Specs.ToList();
            ViewBag.Facility = _dbContext.Facilities.ToList();
            return View(new BoatDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(BoatDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_dbContext.Categories.ToList(), "Id", "LocalizedName");
                ViewBag.Specs = _dbContext.Specs.ToList();
                ViewBag.Facility = _dbContext.Facilities.ToList();
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
                var selectedFacilities = await _dbContext.Facilities
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

            _dbContext.Boats.Add(boat);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _dbContext.Boats
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var boat = await _dbContext.Boats.FirstOrDefaultAsync(b => b.Id == id);
            if (boat == null) return NotFound();
            var model = new BoatEditViewModel
            {
                Id = boat.Id,
                Name = boat.Name,
                CategoryId = boat.CategoryId,
                Code = boat.Code,
                MayToOctoberPrice = boat.MayToOctoberPrice,
                JunePrice = boat.JunePrice,
                JulyToAugustPrice = boat.JulyToAugustPrice,
                SeptemberPrice = boat.SeptemberPrice,
                Width = boat.Width,
                Length = boat.Length,
                Guest = boat.Guest,
                Cabin = boat.Cabin,
                SelectedFacilities = boat.Facilities.Select(f => f.Id).ToList(),
                Specs = boat.BoatSpecs.Select(s => new BoatSpecInputModel
                {
                    SpecId = s.SpecId,
                    ValueTr = s.ValueTr
                }).ToList(),
                ExistingImages = boat.BoatImages.Select(i => new BoatImageViewModel
                {
                    Id = i.Id,
                    Base64Data = i.Image
                }).ToList()
            };
            ViewBag.Categories = new SelectList(_dbContext.Categories.ToList(), "Id", "LocalizedName", boat.CategoryId);
            ViewBag.AllFacilities = _dbContext.Facilities.ToList();
            ViewBag.AllSpecs = _dbContext.Specs.ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BoatEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_dbContext.Categories.ToList(), "Id", "LocalizedName", model.CategoryId);
                ViewBag.AllFacilities = _dbContext.Facilities.ToList();
                ViewBag.AllSpecs = _dbContext.Specs.ToList();
                return View(model);
            }
            var boat = await _dbContext.Boats.FirstOrDefaultAsync(b => b.Id == model.Id);
            if (boat == null) return NotFound();
            var specsInBoat = boat.BoatSpecs;
            var facilitiesInBoat = boat.Facilities;
            var imagesInBoat = boat.BoatImages;
            boat.Name = model.Name ?? "";
            boat.CategoryId = model.CategoryId;
            boat.Code = model.Code;
            boat.MayToOctoberPrice = model.MayToOctoberPrice;
            boat.JunePrice = model.JunePrice;
            boat.JulyToAugustPrice = model.JulyToAugustPrice;
            boat.SeptemberPrice = model.SeptemberPrice;
            boat.Width = model.Width;
            boat.Length = model.Length;
            boat.Guest = model.Guest;
            boat.Cabin = model.Cabin;
            boat.BoatSpecs.Clear();
            if (model.Specs != null)
            {
                foreach (var specInput in model.Specs)
                {
                    boat.BoatSpecs.Add(new BoatSpec
                    {
                        SpecId = specInput.SpecId,
                        ValueTr = specInput.ValueTr,
                        ValueEn = specInput.ValueTr
                    });
                }
            }
            boat.Facilities.Clear();
            if (model.SelectedFacilities != null && model.SelectedFacilities.Any())
            {
                var facilitiesInDb = await _dbContext.Facilities
                    .Where(f => model.SelectedFacilities.Contains(f.Id))
                    .ToListAsync();
                foreach (var facility in facilitiesInDb)
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
            if (model.ExistingImages != null && model.ExistingImages.Any())
            {
                var removeIds = model.ExistingImages.Where(x => x.Remove).Select(x => x.Id).ToList();
                var imagesToRemoveInBoat = boat.BoatImages.Where(bi => removeIds.Contains(bi.Id)).ToList();
                foreach (var image in imagesToRemoveInBoat)
                {
                    boat.BoatImages.Remove(image);
                }
                var imagesToRemove = _dbContext.BoatImages.Where(x => removeIds.Contains(x.Id));
                _dbContext.BoatImages.RemoveRange(imagesToRemove);
            }
            if (model.AdditionalImages != null && model.AdditionalImages.Any())
            {
                foreach (var file in model.AdditionalImages)
                {
                    if (file.Length <= 0) continue;
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
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
