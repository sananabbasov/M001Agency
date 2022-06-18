using Agency.Data;
using Agency.Models;
using Agency.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agency.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var banner = _context.Banners.FirstOrDefault();
            var services = _context.Services.ToList();
            var abouts = _context.Abouts.ToList();
            var teams = _context.Teams.Include(x=>x.Position).ToList();
            var socials = _context.Socials.Include(x=>x.SocialNetwork).ToList();

            
            
            HomeVM vm = new()
            {
                Banner = banner,
                Services = services,
                Abouts = abouts,
                Socials = socials,
                Teams = teams,
            };

            
            return View(vm);
        }

        public IActionResult About()
        {
           
            return View();
        }
        
    }
}
