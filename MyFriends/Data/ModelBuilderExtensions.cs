using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFriends.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFriends.Data
{
    public static class ModelBuilderExtensions
    {
         public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Friend>().HasData(
                new Friend
                {
                    ID = 1,
                    Name = "Hossein Parsa",
                    Age = 30
                },
                 new Friend
                {
                    ID = 2,
                    Name = "Ilnaz Alizadeh",
                    Age = 18
                },
                 new Friend
                {
                    ID = 3,
                    Name = "Amir Sharifi",
                    Age = 35
                }
                );
            return modelBuilder;
         }
    }
}