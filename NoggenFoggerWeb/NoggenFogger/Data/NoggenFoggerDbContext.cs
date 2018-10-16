using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoggenFogger.Data.Entities;

namespace NoggenFogger.Data
{
    public class NoggenFoggerDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public NoggenFoggerDbContext(DbContextOptions<NoggenFoggerDbContext> options)
            : base(options)
        {
        }
    }
}
