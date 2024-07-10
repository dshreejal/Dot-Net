using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
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
            TempData["userId"] = 1;
            var data = "This is session";

            //set session
            HttpContext.Session.SetString("sessionData", data);

            //retrieve session data
            var sessionData = HttpContext.Session.GetString("sessionData");

            //pass session data to view
            ViewBag.SessionData = sessionData;

            // Set cookie
            Response.Cookies.Append("cookieData", "This is a cookie");

            //Get cookie value
            var cookieData = Request.Cookies["cookieData"];

            //pass cookie data to view
            if (cookieData != null)
            {
                ViewBag.CookieData = cookieData;
            }

            // Set hidden field
            ViewData["hiddenData"] = "This is hidden field data";

            return View();
        }

        public IActionResult GetQueryString(string name, int age)
        {

            ViewBag.Name = name;
            ViewBag.Age = age;
            return View();
        }

        public IActionResult Privacy()
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
