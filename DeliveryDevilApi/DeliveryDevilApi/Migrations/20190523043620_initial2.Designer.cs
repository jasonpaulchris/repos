﻿// <auto-generated />
using DeliveryDevilApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DeliveryDevilApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190523043620_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeliveryDevilApi.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerAddress");

                    b.Property<int>("CustomerId");

                    b.Property<string>("CustomerName");

                    b.Property<bool>("HasTipped");

                    b.Property<decimal>("OrderAmount");

                    b.Property<DateTime>("OrderTime");

                    b.Property<string>("RestaurantName");

                    b.Property<decimal>("TippingHistory");

                    b.HasKey("Id");

                    b.ToTable("tblorders");
                });
#pragma warning restore 612, 618
        }
    }
}