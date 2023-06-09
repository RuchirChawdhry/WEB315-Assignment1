using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Models;

    public class RazorPagesLibraryContext : DbContext
    {
        public RazorPagesLibraryContext (DbContextOptions<RazorPagesLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLibrary.Models.Library> Library { get; set; }
    }
