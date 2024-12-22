using Microsoft.AspNetCore.Mvc;

namespace KuaforSalonu.Controllers
{
    public class SalonController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
