﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fish_Registration.Models;

namespace Fish_Registration.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Fish_Registration.Models.Captain> Captain { get; set; }

        public DbSet<Fish_Registration.Models.Vessel> Vessel { get; set; }

        public DbSet<Fish_Registration.Models.Project> Project { get; set; }

        public DbSet<Fish_Registration.Models.CaptainVessel> CaptainVessel { get; set; }
    }
}
