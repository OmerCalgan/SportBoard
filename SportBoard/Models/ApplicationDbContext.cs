﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace SportBoard.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
