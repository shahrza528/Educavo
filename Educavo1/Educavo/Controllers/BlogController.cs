using Educavo.Data;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "blog";
            VmBlog model = new VmBlog() {
                Blogs = _context.Blogs.Include(c => c.BlogCategory).Include(u => u.CustomUser).ToList(),
                RecentBlogs = _context.Blogs.OrderByDescending(o => o.CreatedDate).Take(5).ToList(),
                BlogCategories=_context.BlogCategories.ToList()
            };
            return View(model);
        }
    }
}
