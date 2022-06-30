using Agency.Data;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Areas.dashboard.Controllers
{
    [Area("dashboard")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var banner = _context.Banners.FirstOrDefault();
            return View(banner);
        }
        public IActionResult Create()
        {
            var banner = _context.Banners.ToList();
            if (banner != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
