using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Models;

namespace SampleRazorApp.Models
{
    public class SampleRazorAppContext : DbContext
    {
        public SampleRazorAppContext (DbContextOptions<SampleRazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleRazorApp.Models.Person> Person { get; set; }

        public DbSet<SampleRazorApp.Models.Message> Message { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().Property<string>("Posted");
        }
    }
}