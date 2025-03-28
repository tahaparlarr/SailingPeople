using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SailingPeople.Models;

namespace SailingPeople.Components;

public class CategoryListViewComponent(AppDbContext dbContext, IMapper mapper) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await dbContext.Categories.ToListAsync();
        ViewBag.Categories = categories.Select(p => mapper.Map<CategoryDto>(p));

        return View();
    }
}
