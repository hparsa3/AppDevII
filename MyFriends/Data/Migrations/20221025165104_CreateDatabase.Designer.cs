﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFriends.Data;

#nullable disable

namespace MyFriends.Data.Migrations
{
    [DbContext(typeof(FriendContext))]
    [Migration("20221025165104_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("MyFriends.Models.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("Full Name");

                    b.HasKey("Id");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 30,
                            Name = "Hossein Parsa"
                        },
                        new
                        {
                            Id = 2,
                            Age = 18,
                            Name = "Ilnaz Alizadeh"
                        },
                        new
                        {
                            Id = 3,
                            Age = 35,
                            Name = "Amir Sharifi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}