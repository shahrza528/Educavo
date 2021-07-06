using Educavo.Data;
using Educavo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Active = "Team";
            List<Team> teams1 = _context.Teams.Include(t => t.Position).Include(c => c.Course).ToList();

            decimal dataPage = 5;
            decimal pageCount = Math.Ceiling(teams1.Count / dataPage);

            List<Team> teams = teams1.OrderByDescending(o => o.Id).Skip(Convert.ToInt32((page - 1) * dataPage)).Take((int)dataPage).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.PageCount = pageCount;
            ViewBag.DataPage = dataPage;
            ViewBag.DataCount = teams1.Count;

            return View(teams);
        }

        public IActionResult Create()
        {
            ViewBag.Position = _context.Positions.ToList();
            ViewBag.Course = _context.Courses.ToList();
            ViewBag.Social = _context.Socials.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Team model)
        {
            if (ModelState.IsValid)
            {
                List<SocialToTeam> newSocial = model.SocialToTeams;
                if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                    ViewBag.Position = _context.Positions.ToList();
                    ViewBag.Course = _context.Courses.ToList();
                    return View(model);
                }

                if (model.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                    ViewBag.Position = _context.Positions.ToList();
                    ViewBag.Course = _context.Courses.ToList();
                    return View(model);
                }

                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                model.Image = fileName;
                model.SocialToTeams = null;
                _context.Teams.Add(model);
                _context.SaveChanges();

                foreach (var item in newSocial)
                {
                    if (item.SocialId > 0 && item.Link != null)
                    {
                        SocialToTeam social = new SocialToTeam()
                        {
                            TeamId = model.Id,
                            SocialId = item.SocialId,
                            Link = item.Link
                        };
                        _context.SocialToTeams.Add(social);
                    }
                }

                _context.SaveChanges();


                return RedirectToAction("Index");
            }

            ViewBag.Position = _context.Positions.ToList();
            ViewBag.Course = _context.Courses.ToList();
            return View(model);
        }

        public IActionResult Update(int? teamId)
        {
            if (teamId == null && teamId <= 0)
            {
                return NotFound();
            }

            ViewBag.Position = _context.Positions.ToList();
            ViewBag.Course = _context.Courses.ToList();
            ViewBag.Social = _context.Socials.ToList();

            Team team = _context.Teams
                                     .Include(p => p.Position)
                                     .Include(c => c.Course)
                                     .Include(s => s.SocialToTeams).ThenInclude(ss => ss.Social)
                                     .FirstOrDefault(t => t.Id == teamId);

            return View(team);
        }

        [HttpPost]
        public IActionResult Update(Team model)
        {
            if (ModelState.IsValid)
            {
                List<SocialToTeam> newSocial = model.SocialToTeams;
                List<SocialToTeam> oldSocial = _context.SocialToTeams.Where(s => s.TeamId == model.Id).ToList();

                if (model.ImageFile != null)
                {
                    if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                    {
                        ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                        ViewBag.Position = _context.Positions.ToList();
                        ViewBag.Course = _context.Courses.ToList();
                        return View(model);
                    }

                    if (model.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                        ViewBag.Position = _context.Positions.ToList();
                        ViewBag.Course = _context.Courses.ToList();
                        return View(model);
                    }

                    string oldFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", model.Image);
                    System.IO.File.Delete(oldFilePath);

                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }
                    model.Image = fileName;
                }


                model.SocialToTeams = null;
                _context.Teams.Update(model);
                _context.SaveChanges();

                _context.SocialToTeams.RemoveRange(oldSocial);

                foreach (var item in newSocial)
                {
                    if (item.SocialId > 0 && item.Link != null)
                    {
                        SocialToTeam social = new SocialToTeam()
                        {
                            TeamId = model.Id,
                            SocialId = item.SocialId,
                            Link = item.Link
                        };
                        _context.SocialToTeams.Add(social);
                    }
                }

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Position = _context.Positions.ToList();
            ViewBag.Course = _context.Courses.ToList();
            return View(model);
        }

        public JsonResult GetSocials()
        {
            List<Social> socials = _context.Socials.ToList();
            return Json(socials);
        }
    }
}
