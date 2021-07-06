using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = "about";

            //ViewBag.WishList = Request.Cookies["WishList"];
            return View();
        }
    }
}
