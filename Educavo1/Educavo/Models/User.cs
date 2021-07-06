using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
