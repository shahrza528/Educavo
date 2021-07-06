using Educavo.Data;
using Educavo.Models;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Educavo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(c => c.BlogCategory).Include(u => u.CustomUser).ToList();

            List<VmBlogToExcel> data = blogs.Select(b => new VmBlogToExcel
            {
                Title = b.Title,
                Category = b.BlogCategory.Name,
                User = b.CustomUser.Name,
                Date = b.CreatedDate.ToString("dd.MM.yyyy")
            }).ToList();

            TempData["BlogList"] = JsonConvert.SerializeObject(data);

            return View(blogs);
        }

        public IActionResult Create()
        {
            ViewBag.Category = _context.BlogCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                if (!(model.ImageFile.ContentType == "image/png" || model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/gif"))
                {
                    ModelState.AddModelError("", "You can only upload jpeg, png, and gif");
                    ViewBag.Category = _context.BlogCategories.ToList();
                    return View(model);
                }

                if (model.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("", "You can only upload max 2 Mb size images");
                    ViewBag.Category = _context.BlogCategories.ToList();
                    return View(model);
                }

                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "-" + model.ImageFile.FileName;
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Images", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                }

                model.Image = fileName;
                model.CreatedDate = DateTime.Now;
                model.CustomUserId = _userManager.GetUserId(User);

                _context.Blogs.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Category = _context.BlogCategories.ToList();
            return View(model);
        }

        public IActionResult ExportBlog()
        {
            string blogs = (string)TempData["BlogList"];
            List<VmBlogToExcel> data = JsonConvert.DeserializeObject<List<VmBlogToExcel>>(blogs);

            List<char> letters = new List<char>()
            {
                'A','B', 'C','D','E','F'
            };

            var workbook = new XLWorkbook();
            var ws = workbook.AddWorksheet("Blog list");

            ws.Row(1).Height = 4;
            ws.Row(2).Height = 30;
            ws.Row(3).Height = 22;

            ws.Column("A").Width = 0.3;
            ws.Column("B").Width = 8;
            ws.Column("C").Width = 50;
            ws.Column("D").Width = 30;
            ws.Column("E").Width = 25;
            ws.Column("F").Width = 20;

            ws.Range("B2:F2").Merge();
            ws.Cell("B2").Value = "Blog list";
            ws.Cell("B2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Cell("B2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Cell("B2").Style.Font.SetBold();
            ws.Cell("B2").Style.Font.FontSize = 14;

            for (int i = 0; i < (letters.Count - 1); i++)
            {
                ws.Cell(letters[i + 1] + "3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                ws.Cell(letters[i + 1] + "3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell(letters[i + 1] + "3").Style.Font.SetBold();
                ws.Cell(letters[i + 1] + "3").Style.Font.FontSize = 14;
                ws.Cell(letters[i + 1] + "3").Style.Font.FontColor = XLColor.White;
                ws.Cell(letters[i + 1] + "3").Style.Fill.BackgroundColor = XLColor.Blue;
                ws.Cell(letters[i + 1] + "3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell(letters[i + 1] + "3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell(letters[i + 1] + "3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell(letters[i + 1] + "3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }
            ws.Cell("B3").Value = "#";
            //ws.Cell("B3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //ws.Cell("B3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //ws.Cell("B3").Style.Font.SetBold();
            //ws.Cell("B3").Style.Font.FontSize = 14;
            //ws.Cell("B3").Style.Font.FontColor = XLColor.White;
            //ws.Cell("B3").Style.Fill.BackgroundColor = XLColor.Blue;
            //ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("C3").Value = "Title";
            //ws.Cell("C3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //ws.Cell("C3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //ws.Cell("C3").Style.Font.SetBold();
            //ws.Cell("C3").Style.Font.FontSize = 14;
            //ws.Cell("C3").Style.Font.FontColor = XLColor.White;
            //ws.Cell("C3").Style.Fill.BackgroundColor = XLColor.Blue;
            //ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("D3").Value = "Category";
            //ws.Cell("D3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //ws.Cell("D3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //ws.Cell("D3").Style.Font.SetBold();
            //ws.Cell("D3").Style.Font.FontSize = 14;
            //ws.Cell("D3").Style.Font.FontColor = XLColor.White;
            //ws.Cell("D3").Style.Fill.BackgroundColor = XLColor.Blue;
            //ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("E3").Value = "Posted user";
            //ws.Cell("E3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //ws.Cell("E3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //ws.Cell("E3").Style.Font.SetBold();
            //ws.Cell("E3").Style.Font.FontSize = 14;
            //ws.Cell("E3").Style.Font.FontColor = XLColor.White;
            //ws.Cell("E3").Style.Fill.BackgroundColor = XLColor.Blue;
            //ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Date";
            //ws.Cell("F3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //ws.Cell("F3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            //ws.Cell("F3").Style.Font.SetBold();
            //ws.Cell("F3").Style.Font.FontSize = 14;
            //ws.Cell("F3").Style.Font.FontColor = XLColor.White;
            //ws.Cell("F3").Style.Fill.BackgroundColor = XLColor.Blue;
            //ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            //int j = 4;
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < (letters.Count - 1); j++)
                {
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Font.FontSize = 12;
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    ws.Cell("" + letters[j + 1] + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                    if (letters[j + 1] == 'C')
                    {
                        ws.Cell("C" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                        ws.Cell("C" + (i + 4)).Style.Alignment.WrapText = true;
                    }
                }


                ws.Cell("B" + (i + 4)).Value = i + 1;
                ws.Cell("C" + (i + 4)).Value = data[i].Title;
                ws.Cell("D" + (i + 4)).Value = data[i].Category;
                ws.Cell("E" + (i + 4)).Value = data[i].User;
                ws.Cell("F" + (i + 4)).Value = data[i].Date;

                //ws.Cell("B" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                //ws.Cell("B" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //ws.Cell("B" + (i + 4)).Style.Font.FontSize = 12;
                //ws.Cell("B" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                //ws.Cell("B" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("B" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                //ws.Cell("B" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                //ws.Cell("C" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                //ws.Cell("C" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                //ws.Cell("C" + (i + 4)).Style.Font.FontSize = 12;
                //ws.Cell("C" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                //ws.Cell("C" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("C" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                //ws.Cell("C" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                //ws.Cell("C" + (i + 4)).Style.Alignment.WrapText = true;

                //ws.Cell("D" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                //ws.Cell("D" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //ws.Cell("D" + (i + 4)).Style.Font.FontSize = 12;
                //ws.Cell("D" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                //ws.Cell("D" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("D" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                //ws.Cell("D" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                //ws.Cell("E" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                //ws.Cell("E" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //ws.Cell("E" + (i + 4)).Style.Font.FontSize = 12;
                //ws.Cell("E" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                //ws.Cell("E" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("E" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                //ws.Cell("E" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                //ws.Cell("F" + (i + 4)).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                //ws.Cell("F" + (i + 4)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //ws.Cell("F" + (i + 4)).Style.Font.FontSize = 12;
                //ws.Cell("F" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                //ws.Cell("F" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("F" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                //ws.Cell("F" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Blogs.xlsx");
            }
        }
    }
}
