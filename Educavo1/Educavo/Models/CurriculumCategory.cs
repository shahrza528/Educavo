using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class CurriculumCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("Curriculum")]
        public int CurriculumId { get; set; }
        public Curriculum Curriculum { get; set; }
        public List<CurriculumSubject> CurriculumSubjects { get; set; }
    }
}
