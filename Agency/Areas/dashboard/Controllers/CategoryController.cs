﻿using Agency.Data;
using Agency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Areas.dashboard.Controllers
{
    [Area("dashboard")]
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
            var selectCategory = _context.Categories.FirstOrDefault(c=>c.Name == category.Name);
            if (selectCategory != null)
            {
                ViewBag.CategoryExist = "Category movcuddur";
                return View();
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }



    }
}