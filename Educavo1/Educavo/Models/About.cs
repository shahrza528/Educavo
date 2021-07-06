using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        //[Column(TypeName ="ntext")]
        [MaxLength(2000)]
        public string Description { get; set; }
        public int StudentCount { get; set; }
        public decimal AverageCGPA { get; set; }
        [Column(TypeName = "tinyint")]
        public byte Graduates { get; set; }
        [MaxLength(250)]
        public string Video { get; set; }
        [MaxLength(250)]
        public string VideoImage { get; set; }
    }
}
