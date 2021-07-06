using Educavo.Data;
using Educavo.Models;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Controllers
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
            ViewBag.Active = "home";
            VmHome model = new VmHome();
            model.Sliders = _context.Sliders.ToList();
            model.Features = _context.Features.ToList();
            model.Courses = _context.Courses.Include(d => d.Curriculum)
                                            .ThenInclude(s => s.curriculumCategories)
                                            .ThenInclude(h => h.CurriculumSubjects)
                                            .OrderBy(o=>o.Id).Take(3).ToList();

            //HttpContext.Session.SetString("UserId", "5");
            CookieOptions options = new CookieOptions() {
                Expires = DateTime.Now.AddYears(2)
            };

            //Response.Cookies.Append("WishList", "1-5-45", options);

            return View(model);
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
