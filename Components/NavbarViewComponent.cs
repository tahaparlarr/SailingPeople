using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Models;

namespace SailingPeople.Components;

public class NavbarViewComponent(AppDbContext dbContext) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await dbContext.Categories.ToListAsync();
        ViewBag.Categories = categories.Select(p => new CategoryDto(p));

        return View();
    }
}
