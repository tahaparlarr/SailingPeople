using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Domain;
using SailingPeople.Models;

namespace SailingPeople.Controllers;

public class HomeController(AppDbContext dbContext) : Controller
{
    public async Task<IActionResult> Index()
    {
        var categories = (await dbContext.Categories.ToListAsync()).Select(p => new CategoryDto(p));
        ViewBag.CategoriesSelectList = new SelectList(categories, "Id", "LocalizedName");
        ViewBag.Categories = categories;

        var boats = await dbContext.Boats.ToListAsync();
        ViewBag.Boats = boats.Select(p => new BoatDto(p)).Take(20);

        ViewBag.BoatsGroupedByCategory = boats
            .Where(p => categories.Any(c => c.Id == p.CategoryId))
            .GroupBy(p => p.CategoryId)
            .Select(group => new
            {
                CategoryId = group.Key,
                Boats = group.Select(p => new BoatDto(p)).Take(20).ToList()
            });

        return View();
    }
    public async Task<IActionResult> Category(Guid Id)
    {

        var boats = await dbContext.Boats.Where(p => p.CategoryId == Id).ToListAsync();

        return View(boats);
    }

    public IActionResult Faq()
    {

        return View();
    }

    public async Task<IActionResult> Boats()
    {
        var boats = (await dbContext.Boats.ToListAsync());
        ViewBag.Boats = boats.Select(p => new BoatDto(p));

        return View();
    }
    public async Task<IActionResult> BoatDetail(Guid Id)
    {

        var boat = await dbContext.Boats.FindAsync(Id);


        if (boat == null)
        {
            return NotFound();
        }

        return View(new BoatDto(boat));
    }

    [HttpGet]
    public async Task<IActionResult> Search()
    {
        ViewBag.Categories = (await dbContext.Categories.ToListAsync())
                                .Select(p => new CategoryDto(p));

        return View(new FilterViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Search(FilterViewModel model)
    {
        ViewBag.Categories = (await dbContext.Categories.ToListAsync())
                                  .Select(p => new CategoryDto(p));

        var result = await dbContext.Boats.Where(p =>
        (p.CategoryId == model.CategoryId || model.CategoryId == null) &&
        p.Guest == model.Guests &&
        p.Cabin == model.Cabin
        ).ToListAsync();

        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> Contact()
    {

        return View();
    }

}
