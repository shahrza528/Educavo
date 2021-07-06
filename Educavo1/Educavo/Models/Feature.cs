using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Info { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
    }
}
