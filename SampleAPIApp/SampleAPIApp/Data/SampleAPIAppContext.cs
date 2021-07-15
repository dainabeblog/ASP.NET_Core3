using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleAPIApp.Models;

    public class SampleAPIAppContext : DbContext
    {
        public SampleAPIAppContext (DbContextOptions<SampleAPIAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleAPIApp.Models.Product> Product { get; set; }
    }
