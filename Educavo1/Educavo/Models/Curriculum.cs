using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Curriculum
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<CurriculumCategory> curriculumCategories { get; set; }
    }
}
