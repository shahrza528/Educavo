using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public int StudentCount { get; set; }
        [ForeignKey("Curriculum")]
        public int CurriculumId { get; set; }
        public Curriculum Curriculum { get; set; }
        public decimal Price { get; set; }
        [MaxLength(250)]
        public string Video { get; set; }
        [MaxLength(250)]
        public string VideoImage { get; set; }


        public List<FAQ> FAQs { get; set; }
        public List<Requirement> Requirements { get; set; }
        public List<WhatLearn> WhatLearns { get; set; }
        public List<Team> Teams { get; set; }
    }
}
