using Educavo.Data;
using Educavo.Models;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewComponents
{
    public class Footer : ViewComponent
    {
        private readonly AppDbContext _context;

        public Footer(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            VmFooter model = new VmFooter();
            model.Socials= _context.Socials.ToList();
            model.RecentBlogs= _context.Blogs.OrderByDescending(o => o.Id).Take(2).ToList();
            model.Setting= _context.Settings.FirstOrDefault();

            return View(model);
        }
    }
}
