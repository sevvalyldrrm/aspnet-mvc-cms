﻿// <auto-generated />
using System;
using Cms.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cms.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240125183042_1001DatabaseDeneme")]
    partial class _1001DatabaseDeneme
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cms.Data.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Teknoloji ile ilgili haberler",
                            Name = "Teknoloji"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Spor haberleri",
                            Name = "Spor"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Sağlık ve yaşam tarzı ile ilgili bilgiler",
                            Name = "Sağlık"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Eğitim dünyasından haberler ve ipuçları",
                            Name = "Eğitim"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ekonomi ve finans dünyasına dair güncel bilgiler",
                            Name = "Ekonomi"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Seyahat ipuçları ve destinasyon önerileri",
                            Name = "Seyahat"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Sanat dünyasından son gelişmeler",
                            Name = "Sanat"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Moda dünyasından en son trendler",
                            Name = "Moda"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Yemek kültürü ve gastronomi haberleri",
                            Name = "Gastronomi"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Teknolojideki son yenilikler ve icatlar",
                            Name = "Teknoloji Yenilikleri"
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.CategoryPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("CategoryPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            PostId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            PostId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            PostId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            PostId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            PostId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            PostId = 6
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            PostId = 7
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            PostId = 8
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            PostId = 9
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            PostId = 10
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Bu sayfa şirketimiz hakkında bilgiler içerir.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Hakkımızda",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Content = "Şirketimizin misyonunu bu sayfada bulabilirsiniz.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Misyonumuz",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Content = "Gelecek vizyonumuz hakkında bilgi alın.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Vizyonumuz",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Content = "Kariyer olanaklarımız hakkında bilgi alın.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Kariyer",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Content = "Bizimle iletişim bilgileri.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "İletişim",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Content = "Basın bültenlerimiz ve haberler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Basın Odası",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Content = "Yatırımcılar için önemli bilgiler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Yatırımcı İlişkileri",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Content = "Topluma katkıda bulunduğumuz projeler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Sosyal Sorumluluk Projeleri",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Content = "Müşterilerimizin sık sorduğu sorular.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Sıkça Sorulan Sorular",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Content = "Gizlilik ve veri koruma politikamız.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Title = "Gizlilik Politikası",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Yeni teknolojiler hakkında bilgiler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Yeni Teknolojiler",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Spor dünyasından son gelişmeler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spor Dünyası",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Sağlıklı yaşam için ipuçları.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sağlıklı Yaşam",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 9
                        },
                        new
                        {
                            Id = 4,
                            Content = "Eğitim alanında yaşanan son gelişmeler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Eğitimde Yenilikler",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Dünya ekonomisine genel bir bakış.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ekonomi Analizi",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 8
                        },
                        new
                        {
                            Id = 6,
                            Content = "Keşfedilecek yeni yerler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Seyahat Rehberi",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "Sanat dünyasından haberler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sanatın Kalbi",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            Content = "Moda dünyasının nabzı.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Moda Dünyasında Neler Oluyor?",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 9,
                            Content = "Gastronomi dünyasından lezzetli haberler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Gastronomi Keşifleri",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 6
                        },
                        new
                        {
                            Id = 10,
                            Content = "Teknolojideki son gelişmeler ve inovasyonlar.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Teknolojik Gelişmeler",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 7
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostComments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Harika bir yazı!",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Çok bilgilendirici, teşekkürler.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Bu konuda daha fazla bilgi bekliyorum.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Sporla ilgili bu tür yazıları seviyorum.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Comment = "Yazarın bakış açısını beğendim.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            Comment = "Faydalı bir yazı olmuş.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 6
                        },
                        new
                        {
                            Id = 7,
                            Comment = "Teknolojinin geldiği nokta gerçekten şaşırtıcı.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 7
                        },
                        new
                        {
                            Id = 8,
                            Comment = "Yazar bu konuda çok iyi bilgi sahibi.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 1,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 8
                        },
                        new
                        {
                            Id = 9,
                            Comment = "Spor haberlerini takip etmeyi seviyorum.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 2,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 9
                        },
                        new
                        {
                            Id = 10,
                            Comment = "Daha fazla spor içeriği görmek isterim.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            PostId = 3,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 10
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.PostImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImages");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ImagePath = "images/post2.jpg",
                            PostId = 1
                        },
                        new
                        {
                            Id = 1,
                            ImagePath = "images/post1.jpg",
                            PostId = 1
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "images/post3.jpg",
                            PostId = 1
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "images/post4.jpg",
                            PostId = 2
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "images/post5.jpg",
                            PostId = 2
                        },
                        new
                        {
                            Id = 6,
                            ImagePath = "images/post6.jpg",
                            PostId = 2
                        },
                        new
                        {
                            Id = 7,
                            ImagePath = "images/post7.jpg",
                            PostId = 3
                        },
                        new
                        {
                            Id = 8,
                            ImagePath = "images/post8.jpg",
                            PostId = 3
                        },
                        new
                        {
                            Id = 9,
                            ImagePath = "images/post9.jpg",
                            PostId = 4
                        },
                        new
                        {
                            Id = 10,
                            ImagePath = "images/post10.jpg",
                            PostId = 5
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tema",
                            UserId = 1,
                            Value = "Koyu"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dil",
                            UserId = 1,
                            Value = "Türkçe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tema",
                            UserId = 2,
                            Value = "Açık"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dil",
                            UserId = 2,
                            Value = "İngilizce"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tema",
                            UserId = 3,
                            Value = "Koyu"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dil",
                            UserId = 3,
                            Value = "Türkçe"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tema",
                            UserId = 4,
                            Value = "Açık"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dil",
                            UserId = 4,
                            Value = "İngilizce"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tema",
                            UserId = 5,
                            Value = "Koyu"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Dil",
                            UserId = 5,
                            Value = "Türkçe"
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "İstanbul",
                            Email = "admin@example.com",
                            Name = "Admin",
                            Password = "123456",
                            Phone = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            City = "Ankara",
                            Email = "user1@example.com",
                            Name = "User One",
                            Password = "123456",
                            Phone = "1234567891"
                        },
                        new
                        {
                            Id = 3,
                            City = "İzmir",
                            Email = "user2@example.com",
                            Name = "User Two",
                            Password = "123456",
                            Phone = "1234567892"
                        },
                        new
                        {
                            Id = 4,
                            City = "Antalya",
                            Email = "user3@example.com",
                            Name = "User Three",
                            Password = "123456",
                            Phone = "1234567893"
                        },
                        new
                        {
                            Id = 5,
                            City = "Bursa",
                            Email = "user4@example.com",
                            Name = "User Four",
                            Password = "123456",
                            Phone = "1234567894"
                        },
                        new
                        {
                            Id = 6,
                            City = "Adana",
                            Email = "user5@example.com",
                            Name = "User Five",
                            Password = "123456",
                            Phone = "1234567895"
                        },
                        new
                        {
                            Id = 7,
                            City = "Konya",
                            Email = "user6@example.com",
                            Name = "User Six",
                            Password = "123456",
                            Phone = "1234567896"
                        },
                        new
                        {
                            Id = 8,
                            City = "Gaziantep",
                            Email = "user7@example.com",
                            Name = "User Seven",
                            Password = "123456",
                            Phone = "1234567897"
                        },
                        new
                        {
                            Id = 9,
                            City = "Samsun",
                            Email = "user8@example.com",
                            Name = "User Eight",
                            Password = "123456",
                            Phone = "1234567898"
                        },
                        new
                        {
                            Id = 10,
                            City = "Kayseri",
                            Email = "user9@example.com",
                            Name = "User Nine",
                            Password = "123456",
                            Phone = "1234567899"
                        });
                });

            modelBuilder.Entity("Cms.Data.Entity.CategoryPost", b =>
                {
                    b.HasOne("Cms.Data.Entity.Category", null)
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cms.Data.Entity.Post", null)
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cms.Data.Entity.PostComment", b =>
                {
                    b.HasOne("Cms.Data.Entity.Post", null)
                        .WithMany("PostComments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cms.Data.Entity.PostImage", b =>
                {
                    b.HasOne("Cms.Data.Entity.Post", null)
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cms.Data.Entity.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("Cms.Data.Entity.Post", b =>
                {
                    b.Navigation("CategoryPosts");

                    b.Navigation("PostComments");

                    b.Navigation("PostImages");
                });
#pragma warning restore 612, 618
        }
    }
}
