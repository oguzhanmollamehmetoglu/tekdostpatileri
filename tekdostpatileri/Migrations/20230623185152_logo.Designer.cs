﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tekdostpatileri.Models;

#nullable disable

namespace tekdostpatileri.Migrations
{
    [DbContext(typeof(TekDostPatileriDbContext))]
    [Migration("20230623185152_logo")]
    partial class logo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("tekdostpatileri.Models.Anasayfa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("slider1başlık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider1img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider1yazı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider2başlık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider2img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider2yazı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider3başlık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider3img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider3yazı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider4başlık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider4img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider4yazı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider5başlık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider5img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slider5yazı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("önsöz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("önsözsesleniş")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("anasayfas");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Logo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("logos");
                });
#pragma warning restore 612, 618
        }
    }
}
