using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFriends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyFriends.Data
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
         public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.Property(f => f.Name).HasColumnName("Full Name");
        }
    }
}