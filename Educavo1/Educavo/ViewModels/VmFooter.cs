using Educavo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewModels
{
    public class VmFooter
    {
        public List<Social> Socials { get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public Setting Setting { get; set; }
    }
}
