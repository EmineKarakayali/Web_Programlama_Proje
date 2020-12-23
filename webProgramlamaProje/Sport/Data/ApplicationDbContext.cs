using System;
using System.Collections.Generic;
using System.Text;
using ExtremeSports.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sport.Models;

namespace Sport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Member> Member { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<MemSport> MemSport { get; set; }
        public DbSet<MemMeet> MemMeet { get; set; }
        public DbSet<MemComty> MemComty { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Community> Community { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Country> Country { get; set; }
    }
}
