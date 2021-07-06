using Educavo.Data;
using Educavo.Models;
using Educavo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Educavo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin, Moderator")]
    public class SubscribeController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public SubscribeController(AppDbContext context, UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(_context.Subscribes.ToList());
        }

        public IActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMail(VmEmail model)
        {
            List<Subscribe> subscribes = _context.Subscribes.ToList();
            foreach (var item in subscribes)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("codegroupsp@gmail.com", "Automail");
                mail.To.Add(item.Email);
                mail.Subject = model.Subject;
                mail.Body = model.Content;
                mail.IsBodyHtml = true;
                //mail.CC.Add("shohret550@gmail.com");

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("codegroupsp@gmail.com", "codegroupsp2021");

                smtpClient.Send(mail);
            }

            return RedirectToAction("Index");
        }
    }
}
