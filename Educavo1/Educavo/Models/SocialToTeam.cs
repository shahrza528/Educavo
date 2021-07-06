using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class SocialToTeam
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }
        [ForeignKey("Social")]
        public int SocialId { get; set; }
        public Social Social { get; set; }
    }
}
