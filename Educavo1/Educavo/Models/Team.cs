using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educavo.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string FullName { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        [MaxLength(250), Required]
        public string Info { get; set; }
        public int StudentCount { get; set; }
        [MaxLength(2000), Required]
        public string Description { get; set; }
        [MaxLength(2000)]
        public string Description2 { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(20), Required]
        public string Phone { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<SocialToTeam> SocialToTeams { get; set; }
        public List<SkillToTeam> SkillToTeams { get; set; }
    }
}
