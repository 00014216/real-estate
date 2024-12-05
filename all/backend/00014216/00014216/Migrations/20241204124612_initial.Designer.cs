﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _00014216.Data;

#nullable disable

namespace _00014216.Migrations
{
    [DbContext(typeof(RealEstateDbContext))]
    [Migration("20241204124612_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.36");

            modelBuilder.Entity("_00014216.Models.Property", b =>
                {
                    b.Property<int>("PropertyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bathrooms")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bedrooms")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateListed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SquareFeet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PropertyID");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("_00014216.Models.PropertyFeatures", b =>
                {
                    b.Property<int>("FeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FeatureName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FeatureValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PropertyID")
                        .HasColumnType("INTEGER");

                    b.HasKey("FeatureID");

                    b.HasIndex("PropertyID");

                    b.ToTable("PropertyFeatures");
                });

            modelBuilder.Entity("_00014216.Models.PropertyFeatures", b =>
                {
                    b.HasOne("_00014216.Models.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
