using Agency.Data;
using Agency.Models;
using Microsoft.AspNetCore.Mvc;

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
            
            return View(services);
        }

        public IActionResult About()
        {
           
            return View();
        }
        
    }
}
