using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Requirement
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Name { get; set; }
        [ForeignKey("Course")]
        public int CourseId{ get; set; }
        public Course Course { get; set; }
    }
}
