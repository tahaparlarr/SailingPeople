using Microsoft.AspNetCore.Mvc;

namespace SailingPeople.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
