using Educavo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewModels
{
    public class VmHome: VmBase
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Course> Courses { get; set; }
    }
}
