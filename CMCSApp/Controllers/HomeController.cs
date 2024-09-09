using CMCSApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMCSApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Claims()
        {
            return View();
        }

        public IActionResult LecturerForm()
        {
            return View();
        }
        public IActionResult SubmittedClaims()
        {
            return View();
        }
        public IActionResult ClaimReviews()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
