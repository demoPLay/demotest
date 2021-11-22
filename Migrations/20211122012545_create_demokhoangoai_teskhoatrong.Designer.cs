﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demotest.data;

namespace demotest.Migrations
{
    [DbContext(typeof(applicatinodbContext))]
    [Migration("20211122012545_create_demokhoangoai_teskhoatrong")]
    partial class create_demokhoangoai_teskhoatrong
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("demotest.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("demotest.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryID")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.HasIndex("categoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("demotest.Models.Productt", b =>
                {
                    b.Property<string>("ProducttID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProducttName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryyID")
                        .HasColumnType("TEXT");

                    b.HasKey("ProducttID");

                    b.HasIndex("categoryyID");

                    b.ToTable("Productt");
                });

            modelBuilder.Entity("demotest.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Student");
                });

            modelBuilder.Entity("demotest.Models.category", b =>
                {
                    b.Property<string>("categoryID")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("categoryID");

                    b.ToTable("categorys");
                });

            modelBuilder.Entity("demotest.Models.categoryy", b =>
                {
                    b.Property<string>("categoryyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("categoryyName")
                        .HasColumnType("TEXT");

                    b.HasKey("categoryyID");

                    b.ToTable("categoryss");
                });

            modelBuilder.Entity("demotest.Models.demokhoangoai", b =>
                {
                    b.Property<string>("demokhoangoaiID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("demokhoangoaiName")
                        .HasColumnType("TEXT");

                    b.Property<string>("teskhoatrongID")
                        .HasColumnType("TEXT");

                    b.HasKey("demokhoangoaiID");

                    b.HasIndex("teskhoatrongID");

                    b.ToTable("demokhoangoai");
                });

            modelBuilder.Entity("demotest.Models.person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("person");
                });

            modelBuilder.Entity("demotest.Models.preson", b =>
                {
                    b.Property<string>("nameID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("nameID");

                    b.ToTable("preson");
                });

            modelBuilder.Entity("demotest.Models.teskhoatrong", b =>
                {
                    b.Property<string>("teskhoatrongID")
                        .HasColumnType("TEXT");

                    b.Property<string>("teskhoatrongName")
                        .HasColumnType("TEXT");

                    b.HasKey("teskhoatrongID");

                    b.ToTable("teskhoatrong");
                });

            modelBuilder.Entity("demotest.Models.test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("test");
                });

            modelBuilder.Entity("demotest.Models.demokt", b =>
                {
                    b.HasBaseType("demotest.Models.Student");

                    b.Property<string>("demoktID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("demoktName")
                        .HasColumnType("TEXT");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("demokt");
                });

            modelBuilder.Entity("demotest.Models.game", b =>
                {
                    b.HasBaseType("demotest.Models.person");

                    b.Property<string>("gameID")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("gameName")
                        .HasColumnType("TEXT");

                    b.ToTable("person");

                    b.HasDiscriminator().HasValue("game");
                });

            modelBuilder.Entity("demotest.Models.Product", b =>
                {
                    b.HasOne("demotest.Models.category", "category")
                        .WithMany("Products")
                        .HasForeignKey("categoryID");

                    b.Navigation("category");
                });

            modelBuilder.Entity("demotest.Models.Productt", b =>
                {
                    b.HasOne("demotest.Models.categoryy", "categoryy")
                        .WithMany("Productts")
                        .HasForeignKey("categoryyID");

                    b.Navigation("categoryy");
                });

            modelBuilder.Entity("demotest.Models.demokhoangoai", b =>
                {
                    b.HasOne("demotest.Models.teskhoatrong", "teskhoatrong")
                        .WithMany("demokhoangoai")
                        .HasForeignKey("teskhoatrongID");

                    b.Navigation("teskhoatrong");
                });

            modelBuilder.Entity("demotest.Models.category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("demotest.Models.categoryy", b =>
                {
                    b.Navigation("Productts");
                });

            modelBuilder.Entity("demotest.Models.teskhoatrong", b =>
                {
                    b.Navigation("demokhoangoai");
                });
#pragma warning restore 612, 618
        }
    }
}