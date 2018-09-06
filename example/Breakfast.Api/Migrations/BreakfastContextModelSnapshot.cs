﻿// <auto-generated />
using System;
using Breakfast.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Breakfast.Api.Migrations
{
    [DbContext(typeof(BreakfastContext))]
    partial class BreakfastContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Breakfast.Api.Entities.BreakfastItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("Rating");

                    b.HasKey("Id");

                    b.ToTable("BreakfastItems");
                });
#pragma warning restore 612, 618
        }
    }
}
