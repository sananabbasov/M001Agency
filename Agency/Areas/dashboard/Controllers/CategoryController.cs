using Agency.Data;
using Agency.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Areas.dashboard.Controllers
{
    [Area("dashboard")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var allCategory = _context.Categories.ToList();

            return View(allCategory);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var selectCategory = _context.Categories.FirstOrDefault(c => c.Name == category.Name);
            if (selectCategory != null)
            {
                ViewBag.CategoryExist = "Category movcuddur";
                return View();
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (id == null)
                return NotFound();
            if (category == null)
                return NotFound();
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int? id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (id == null)
                return NotFound();
            if (category == null)
                return NotFound();
            return View(category);

        }

        [HttpPost]
        public IActionResult Remove(Category category)
        {
            try
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                var portfolios = _context.Portfolios.Where(x => x.CategoryId == category.Id).ToList();

                if (portfolios != null)
                {
                    ViewBag.CategoryError = "Bu kateqoriyada asagidaki portfolio olduguna gore sile bilmezsiniz.";
                    ViewData["portfolios"] = portfolios;
                }
                else
                {
                    ViewBag.CategoryError = "Bilinmeyen sebebden error cixdi. Zehmet olmasa yeniden cehd edin.";
                }

                return View();
            }



        }






    }
}
