using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportProject.Models;

namespace SportProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<Member>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sports> Sports { get; set; }
        //public DbSet<Post> Post { get; set; }
        //public DbSet<Meeting> Meeting { get; set; }
        //public DbSet<Community> Community { get; set; }
        public DbSet<Comment> Comment { get; set; }
        //public DbSet<MemSport> MemSports { get; set; }
        //public DbSet<MemMeet> MemMeet { get; set; }
        //public DbSet<MemComty> MemComty { get; set; }
        //public DbSet<City> City { get; set; }
        //public DbSet<Country> Country { get; set; }
        public DbSet<Courses> Courses { get; set; }
        //public DbSet<CourseCom> CourseCom { get; set; }
    }
}
