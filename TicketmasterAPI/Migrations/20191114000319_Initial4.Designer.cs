﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketmasterAPI.Models;

namespace TicketmasterAPI.Migrations
{
    [DbContext(typeof(DBModelContext))]
    [Migration("20191114000319_Initial4")]
    partial class Initial4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketmasterAPI.Models.FavEvents", b =>
                {
                    b.Property<int>("DbId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Date");

                    b.Property<string>("GenreName");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Url");

                    b.Property<string>("UserName");

                    b.HasKey("DbId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TicketmasterAPI.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FavEventsDbId");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("FavEventsDbId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketmasterAPI.Models.Users", b =>
                {
                    b.HasOne("TicketmasterAPI.Models.FavEvents")
                        .WithMany("UserEvents")
                        .HasForeignKey("FavEventsDbId");
                });
#pragma warning restore 612, 618
        }
    }
}
