using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class CurriculumSubject
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
        [ForeignKey("CurriculumCategory")]
        public int CurriculumCategoryId { get; set; }
        public CurriculumCategory CurriculumCategory { get; set; }
    }
}
