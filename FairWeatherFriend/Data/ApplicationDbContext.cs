using System;
using System.Collections.Generic;
using System.Text;
using FairWeatherFriend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FairWeatherFriend.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
    }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<FairWeatherFriend.Models.RaceTrack> RaceTrack { get; set; }
        public DbSet<FairWeatherFriend.Models.Race> Race { get; set; }
    }
}
