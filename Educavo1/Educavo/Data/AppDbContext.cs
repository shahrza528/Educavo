using Educavo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Educavo.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<About> About { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Curriculum> Curricula { get; set; }
        public DbSet<CurriculumCategory> CurriculumCategories { get; set; }
        public DbSet<CurriculumSubject> CurriculumSubjects { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PanelUser> PanelUsers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillToTeam> SkillToTeams { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialToTeam> SocialToTeams { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WhatLearn> WhatLearns { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
    }
}
