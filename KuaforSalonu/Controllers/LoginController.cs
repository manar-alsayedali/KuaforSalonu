using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Kuafor_Salonu.Models;
using Kuafor_Salonu.Data;

namespace Kuafor_Salonu.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Oturum açma işlemi (örnek: bir oturum çerezi oluştur)
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetString("Role", user.Role.ToString());

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
