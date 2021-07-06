using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }
    }
}
