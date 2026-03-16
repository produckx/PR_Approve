using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PR_Approve.Models;


namespace PR_Approve.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("user");

            if (user == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
