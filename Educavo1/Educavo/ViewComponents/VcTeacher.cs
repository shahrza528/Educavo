using Educavo.Data;
using Educavo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewComponents
{
    public class VcTeacher : ViewComponent
    {
        private readonly AppDbContext _context;

        public VcTeacher(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int? teamCount, string position)
        {
            List<Team> teams;
            int count = 0;

            if (teamCount != null)
            {
                count = Convert.ToInt32(teamCount);
                //teams = _context.Teams.Include(p => p.Position).Include(t => t.SocialToTeams).ThenInclude(s => s.Social).Take(count).ToList();
                teams = _context.Teams.Include(p => p.Position)
                                      .Include(t => t.SocialToTeams).ThenInclude(s => s.Social)
                                      .Where(t => t.Position.Name == position)
                                      .Take(count).ToList();
            }
            else
            {
                teams = _context.Teams.Include(p => p.Position).Include(t => t.SocialToTeams).ThenInclude(s => s.Social).ToList();
            }

            return View(teams);
        }
    }
}
