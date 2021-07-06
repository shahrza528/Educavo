using Educavo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.ViewModels
{
    public class VmBlog:VmBase
    {
        public List<Blog> Blogs{ get; set; }
        public List<Blog> RecentBlogs { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
    }
}
