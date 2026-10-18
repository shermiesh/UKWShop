using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UKWShop.Models;

namespace UKWShop.Controllers
{
    public class HomeController : Controller
    {
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
