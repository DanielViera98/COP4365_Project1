﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COP4365.Migrations
{
    [DbContext(typeof(StockContext))]
    partial class StockContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("Close")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("High")
                        .HasColumnType("REAL");

                    b.Property<double>("Low")
                        .HasColumnType("REAL");

                    b.Property<double>("Open")
                        .HasColumnType("REAL");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("StockFileGuid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Volume")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StockFileGuid");

                    b.ToTable("Stocks", (string)null);
                });

            modelBuilder.Entity("StockFile", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Guid");

                    b.ToTable("StockFiles", (string)null);
                });

            modelBuilder.Entity("Stock", b =>
                {
                    b.HasOne("StockFile", null)
                        .WithMany("Stocks")
                        .HasForeignKey("StockFileGuid");
                });

            modelBuilder.Entity("StockFile", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
