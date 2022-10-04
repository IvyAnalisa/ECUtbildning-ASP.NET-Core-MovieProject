using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IvyBio.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Administrator")]
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
