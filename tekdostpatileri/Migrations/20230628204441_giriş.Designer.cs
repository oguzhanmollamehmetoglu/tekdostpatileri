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
    [Migration("20230628204441_giriş")]
    partial class giriş
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

            modelBuilder.Entity("tekdostpatileri.Models.Cevap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cevaplar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cevaps");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Galeri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Resimler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("galeris");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Giriş", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KullanıcıAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("girişs");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Hakkında", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("kurucuresmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıp1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıp2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşamacıyazı9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşimg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşunadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşyazı1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşyazı2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kuruluşyazı3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazı1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazı2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazı3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yazı4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hakkındas");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Hizmetler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("eğitimp1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hayvankurtarmap1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hayvankurtarmap2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmaimg1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmaimg2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kısırlaştırmap7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sağlıkimg1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sağlıkimg2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sağlıkp1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sağlıkp2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sağlıkp3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("şiddetönlemep1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("şiddetönlemep2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("şiddetönlemep3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("şiddetönlemep4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hizmetlers");
                });

            modelBuilder.Entity("tekdostpatileri.Models.İletişim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tweater")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İnstagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("iletişims");
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

            modelBuilder.Entity("tekdostpatileri.Models.Mail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("mails");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Ödeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankaAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankaŞehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankaŞube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EURO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GBP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ödemes");
                });

            modelBuilder.Entity("tekdostpatileri.Models.Yuvamız", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("YuvaCinsi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YuvaCinsiyeti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YuvaHikaye")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YuvaRengi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YuvaResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YuvaYaşı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yuvaİsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("yuvamızs");
                });
#pragma warning restore 612, 618
        }
    }
}
