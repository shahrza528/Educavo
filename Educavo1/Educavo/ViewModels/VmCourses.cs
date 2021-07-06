using Educavo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewModels
{
    public class VmCourses: VmBase
    {
        public List<Course> Courses { get; set; }
        public Course Course { get; set; }
        public List<Social> Socials { get; set; }
    }
}
