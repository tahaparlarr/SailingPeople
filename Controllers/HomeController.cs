using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Models;

namespace SailingPeople.Controllers;

public class HomeController(AppDbContext dbContext) : Controller
{
    public async Task<IActionResult> Index()
    {
        var categories = await dbContext.Categories.ToListAsync();

        ViewBag.CategoriesSelectList = new SelectList(categories, "Id", "NameTr");
        ViewBag.Boats = (await dbContext.Boats.ToListAsync()).Select(p => new BoatDto(p));
        ViewBag.Categories = (await dbContext.Categories.ToListAsync()).Select(p => new CategoryDto(p));

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

    [HttpPost]
    public async Task<IActionResult> Search(FilterViewModel model)
    {
        var result = await dbContext.Boats.Where(p =>
        p.CategoryId == model.CategoryId &&
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
