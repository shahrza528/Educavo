using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        public byte Age { get; set; }
        public bool IsMarried { get; set; }
        public bool Gender { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
