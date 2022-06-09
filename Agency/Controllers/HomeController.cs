using Agency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Controllers
{
    public class HomeController : Controller
    {
        Banner banner = new()
        {
            Id = 1,
            PhotoURL = "https://startbootstrap.github.io/startbootstrap-agency/assets/img/header-bg.jpg",
            Title = "Welcome To Our Studio!",
            Subtitle = "IT'S NICE TO MEET YOU"
        };
        public IActionResult Index()
        {

            ViewBag.Title = "Salam";
            ViewBag.Banner = banner;
            ViewData["desc"] = "Sagol";
            return View();
        }

        public IActionResult About()
        {
           
            return View();
        }
        
    }
}
