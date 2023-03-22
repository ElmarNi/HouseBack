using HouseBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.DAL
{
    public class HouseDbContext : DbContext
    {
        public HouseDbContext(DbContextOptions<HouseDbContext> options) : base(options) { }
        public DbSet<HomeBanner> HomeBanner { get; set; }
        public DbSet<WhatWeDoHomePage> WhatWeDoHomePage { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }
        public DbSet<ProjectDetailImage> ProjectDetailImages { get; set; }
        public DbSet<AboutHeader> AboutHeader { get; set; }
        public DbSet<OurPrinciple> OurPrinciple { get; set; }
        public DbSet<OurMission> OurMission { get; set; }
        public DbSet<OurHistory> OurHistory { get; set; }
        
    }
}
