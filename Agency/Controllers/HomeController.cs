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
            Title = "Welcome M001!",
            Subtitle = "IT'S NICE TO MEET YOU"
        };
        List<Service> services = new()
        {
            new Service { Id = 1, Icon= "fa-solid fa-bicycle", Title="Test 1",Description="test" },
            new Service { Id = 2, Icon= "fa-solid fa-bezier-curve", Title="Test 2",Description="test" },
            new Service { Id = 3, Icon= "fa-solid fa-beer-mug-empty", Title="Test 3",Description= "test" },
            new Service { Id = 4, Icon= "fa-solid fa-battery-full", Title="Test 4",Description= "test" },
            new Service { Id = 5, Icon= "fa-brands fa-blogger", Title="Test 5",Description= "test" }
        };
        public IActionResult Index()
        {
            ViewBag.Title = "Salam";
            ViewBag.Banner = banner;
            ViewBag.Services = services;
            ViewData["MyServices"] = services;
            return View();
        }

        public IActionResult About()
        {
           
            return View();
        }
        
    }
}
