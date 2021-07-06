using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = "other";
            return View();
        }
    }
}
