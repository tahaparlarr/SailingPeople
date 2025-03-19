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
        var categories = await dbContext.Categories.ToListAsync();
        ViewBag.CategoriesSelectList = new SelectList(categories, "Id", "NameTr");
        ViewBag.Categories = categories.Select(p => new CategoryDto(p));

        var boats = await dbContext.Boats.ToListAsync();
        ViewBag.Boats = boats.Select(p => new BoatDto(p)).Take(20);

        return View();
    }

    public async Task<IActionResult> Category(Guid Id)
    {
        var boats = await dbContext.Boats.Where(p => p.CategoryId == Id).ToListAsync();

        return View(boats);
    }

    public IActionResult Privacy()
    {
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

    [HttpPost]
    public async Task<IActionResult> Search(FilterViewModel model)
    {

        ViewBag.Categories = (await dbContext.Categories.ToListAsync()).Select(p => new CategoryDto(p));

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

    public IActionResult Contact()
    {
        return View();
    }

}
