using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFriends.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFriends.Data
{
    public class FriendContext  : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Friend.db");
        }
          protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FriendConfiguration());
    }
    }
}