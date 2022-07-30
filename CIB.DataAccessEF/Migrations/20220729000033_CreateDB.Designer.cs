﻿// <auto-generated />
using System;
using CIB.DataAccessEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIB.DataAccessEF.Migrations
{
    [DbContext(typeof(PhoneBookContext))]
    [Migration("20220729000033_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CIB.Domain.Models.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntryId"), 1L, 1);

                    b.Property<string>("EntryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneBookId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntryId");

                    b.HasIndex("PhoneBookId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("CIB.Domain.Models.PhoneBook", b =>
                {
                    b.Property<int>("PhoneBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneBookId"), 1L, 1);

                    b.Property<string>("PhoneBookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneBookId");

                    b.ToTable("PhoneBook");
                });

            modelBuilder.Entity("CIB.Domain.Models.Entry", b =>
                {
                    b.HasOne("CIB.Domain.Models.PhoneBook", null)
                        .WithMany("Entires")
                        .HasForeignKey("PhoneBookId");
                });

            modelBuilder.Entity("CIB.Domain.Models.PhoneBook", b =>
                {
                    b.Navigation("Entires");
                });
#pragma warning restore 612, 618
        }
    }
}
