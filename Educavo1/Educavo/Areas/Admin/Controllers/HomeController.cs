using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin, Moderator")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = "Dashboard";
            ViewBag.Role = "kfjvn";
            return View();
        }
    }
}
