using System.Diagnostics;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Domain;
using SailingPeople.Models;

namespace SailingPeople.Controllers;

public class HomeController(AppDbContext dbContext, IMapper mapper) : Controller
{
    public async Task<IActionResult> Index()
    {
        var categories = (await dbContext.Categories.ToListAsync()).Select(p => mapper.Map<CategoryDto>(p));
        ViewBag.CategoriesSelectList = new SelectList(categories, "Id", "LocalizedName");
        ViewBag.Categories = categories;

        var boats = await dbContext.Boats.ToListAsync();
        ViewBag.Boats = boats.Select(p => mapper.Map<BoatDto>(p)).Take(20);

        ViewBag.BoatsGroupedByCategory = boats
            .Where(p => categories.Any(c => c.Id == p.CategoryId))
            .GroupBy(p => p.CategoryId)
            .Select(group => new
            {
                CategoryId = group.Key,
                Boats = group.Select(p => mapper.Map<BoatDto>(p)).Take(20).ToList()
            });

        return View();
    }
    public async Task<IActionResult> Category(Guid Id)
    {
        var categories = (await dbContext.Categories.Where(p => p.Id == Id).ToListAsync()).Select(p => mapper.Map<CategoryDto>(p));
        ViewBag.Categories = categories;

        var boats = (await dbContext.Boats.Where(p => p.CategoryId == Id).ToListAsync()).Select(p => mapper.Map<BoatDto>(p));
        ViewBag.Boats = boats;

        return View(boats);
    }

    public IActionResult Faq()
    {

        return View();
    }

    public async Task<IActionResult> Boats()
    {
        var boats = (await dbContext.Boats.ToListAsync());
        ViewBag.Boats = boats.Select(p => mapper.Map<BoatDto>(p));

        return View();
    }
    public async Task<IActionResult> BoatDetail(Guid Id)
    {
        var boat = await dbContext.Boats.FindAsync(Id);

        if (boat == null)
        {
            return NotFound();
        }

        return View(mapper.Map<BoatDto>(boat));
    }

    [HttpPost]
    public async Task<IActionResult> Search(FilterViewModel model)
    {
        ViewBag.Categories = (await dbContext.Categories.ToListAsync())
                                      .Select(p => mapper.Map<CategoryDto>(p));

        var boats = await dbContext.Boats.Where(p =>
            (p.CategoryId == model.CategoryId || model.CategoryId == null) &&
            (p.Guest == model.Guests) &&
            p.Cabin == model.Cabin
        ).ToListAsync();

        var filteredBoat = boats.Select(boat => mapper.Map<BoatDto>(boat)).ToList();

        return View(filteredBoat);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SearchByBoatCode(CodeFilterViewModel model)
    {
        var code = (model.BoatCode ?? string.Empty).Trim().ToLower();

        if (string.IsNullOrWhiteSpace(code))
        {
            return RedirectToAction("Index");
        }

        var boats = await dbContext.Boats
                        //.Where(p => p.Code == model.BoatCode)
                        .Where(p => p.Code.ToLower().Contains(code))
            .ToListAsync();

        ViewBag.Categories = (await dbContext.Categories.ToListAsync())
                                      .Select(p => mapper.Map<CategoryDto>(p));


        var filteredBoat = boats.Select(boat => mapper.Map<BoatDto>(boat)).ToList();

        return View("CodeSearch", filteredBoat);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Gocek()
    {
        return View();
    }

    public IActionResult Hisaronu()
    {
        return View();
    }

}
