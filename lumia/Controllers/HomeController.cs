using Microsoft.AspNetCore.Mvc;

namespace lumia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
