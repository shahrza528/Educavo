using Educavo.Data;
using Educavo.Models;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Controllers
{
    public class CourseController : Controller
    {

        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ViewBag.Active = "course";

            VmCourses model = new VmCourses();


            List<Course> courses = _context.Courses.Include(c => c.WhatLearns)
                                            .Include(v => v.Requirements)
                                            .Include(d => d.Curriculum)
                                            .ThenInclude(s => s.curriculumCategories)
                                            .ThenInclude(h => h.CurriculumSubjects).ToList();
            List<Social> socials = _context.Socials.ToList();
            //"2-17-18";
            var data = Request.Cookies["Cart"];
            if (data!=null)
            {
                List<string> cookieData = Request.Cookies["Cart"].Split("-").ToList();
                ViewBag.CartCount = cookieData.Count;
                model.Cart = _context.Courses.Where(c => cookieData.Any(d => d == c.Id.ToString())).ToList();
            }
            model.Courses = courses;
            model.Socials = socials;

            return View(model);
        }

        public IActionResult Details(int CourseId)
        {
            ViewBag.Active = "course";

            VmCourses model = new VmCourses();
            model.Course = _context.Courses.Include(c => c.WhatLearns)
                                            .Include(v => v.Requirements)
                                            .Include(d => d.Curriculum)
                                            .ThenInclude(s => s.curriculumCategories)
                                            .ThenInclude(h => h.CurriculumSubjects)
                                            .FirstOrDefault(c => c.Id == CourseId);

            var data = Request.Cookies["Cart"];
            if (data != null)
            {
                List<string> cookieData = Request.Cookies["Cart"].Split("-").ToList();
                ViewBag.CartCount = cookieData.Count;
                model.Cart = _context.Courses.Where(c => cookieData.Any(d => d == c.Id.ToString())).ToList();
            }

            return View(model);
        }

        public JsonResult AddToCard(int courseId)
        {
            string data = "2-17-18-2-2-2-2-2";
            string responseTypeBase;
            var oldData = Request.Cookies["Cart"];
            if (oldData != null)
            {
                List<string> oldDataArr = oldData.Split("-").ToList();
                bool isExist = oldDataArr.Any(d => d == courseId.ToString());
                responseTypeBase = "not-added";

                if (!isExist)
                {
                    var newData = oldData + "-" + courseId;
                    Response.Cookies.Append("Cart", newData);
                    responseTypeBase = "added";
                }
            }
            else
            {
                Response.Cookies.Append("Cart", courseId.ToString());
                responseTypeBase = "created";
            }



            return Json(new { statusCode = 200, responseType = responseTypeBase });
        }
    }
}
