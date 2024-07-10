using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication; // to add authentication
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace AuthenticationAndAuthorization.Controllers
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
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            //take return url to view for this use viewbag
            ViewData["returnURL"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password, string ReturnUrl)
        {
            Console.WriteLine("username", username);
            Console.WriteLine("password", password);
            if (username == "ram" && password == "ram")
            {
                // add authroization
                // claim: authorization detail
                // identity: which mechanism to be used for authorization:cookie
                // principal: who is authorized
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, username));

                /** adding role **/
                claims.Add(new Claim(ClaimTypes.Role, "Student")); // adding role

                // identity->claims
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                // principal->identity
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                // executing->sign in
                HttpContext.SignInAsync(principal); //execute
                return Redirect(ReturnUrl);
            }
            return View();
        }

        [Authorize(Roles = "Student")]
        [HttpGet]
        public IActionResult Dashboard()
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
