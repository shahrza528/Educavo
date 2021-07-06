using Educavo.Data;
using Educavo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin, Moderator")]
    public class BlogCategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoriesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Blog";

            List<BlogCategory> categories = _context.BlogCategories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategory model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogCategories.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            //ModelState.AddModelError("", "Qaga biraz diqqetli ol...");
            return View();

        }

        public IActionResult Update(int? blogCatId)
        {
            BlogCategory blogCategory = _context.BlogCategories.Find(blogCatId);
            return View(blogCategory);
        }

        [HttpPost]
        public IActionResult Update(BlogCategory model)
        {
            if (ModelState.IsValid)
            {
                _context.BlogCategories.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Qaga biraz diqqetli ol...");
            return View();

        }

        public IActionResult Delete(int? blogCatId)
        {
            if (_context.Blogs.Any(b=>b.BlogCategoryId== blogCatId))
            {
                TempData["NoDeleteCategory"] = "Qaga silsen batdin...";
                return RedirectToAction("Index");
            }

            BlogCategory blogCategory = _context.BlogCategories.Find(blogCatId);
            _context.BlogCategories.Remove(blogCategory);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
