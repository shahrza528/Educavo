using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Setting
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(250)]
        public string Logo1 { get; set; }
        [MaxLength(250)]
        public string Logo2 { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(1500)]
        public string About { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
