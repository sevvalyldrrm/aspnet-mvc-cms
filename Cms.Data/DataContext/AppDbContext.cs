﻿using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.DataContext
{
	public class AppDbContext : DbContext
	{
		private readonly IConfiguration _configuration;
		public AppDbContext() { }

		public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var connectionString = _configuration.GetConnectionString("DBConStr");
				optionsBuilder.UseSqlServer(connectionString);
			}
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryPost> CategoryPosts { get; set; }
		public DbSet<PostImage> PostImages { get; set; }
		public DbSet<PostComment> PostComments { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<Setting> Settings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
		new Category { Id = 1, Name = "Teknoloji", Description = "Teknoloji ile ilgili haberler" },
		new Category { Id = 2, Name = "Spor", Description = "Spor haberleri" },
		new Category { Id = 3, Name = "Sağlık", Description = "Sağlık ve yaşam tarzı ile ilgili bilgiler" },
		new Category { Id = 4, Name = "Eğitim", Description = "Eğitim dünyasından haberler ve ipuçları" },
		new Category { Id = 5, Name = "Ekonomi", Description = "Ekonomi ve finans dünyasına dair güncel bilgiler" },
		new Category { Id = 6, Name = "Seyahat", Description = "Seyahat ipuçları ve destinasyon önerileri" },
		new Category { Id = 7, Name = "Sanat", Description = "Sanat dünyasından son gelişmeler" },
		new Category { Id = 8, Name = "Moda", Description = "Moda dünyasından en son trendler" },
		new Category { Id = 9, Name = "Gastronomi", Description = "Yemek kültürü ve gastronomi haberleri" },
		new Category { Id = 10, Name = "Teknoloji Yenilikleri", Description = "Teknolojideki son yenilikler ve icatlar" }

	);
			modelBuilder.Entity<Post>().HasData(
		new Post { Id = 1, UserId = 1, Title = "Yeni Teknolojiler", Content = "Yeni teknolojiler hakkında bilgiler." },
		new Post { Id = 2, UserId = 1, Title = "Spor Dünyası", Content = "Spor dünyasından son gelişmeler." },
		new Post { Id = 3, UserId = 9, Title = "Sağlıklı Yaşam", Content = "Sağlıklı yaşam için ipuçları." },
		new Post { Id = 4, UserId = 2, Title = "Eğitimde Yenilikler", Content = "Eğitim alanında yaşanan son gelişmeler." },
		new Post { Id = 5, UserId = 8, Title = "Ekonomi Analizi", Content = "Dünya ekonomisine genel bir bakış." },
		new Post { Id = 6, UserId = 3, Title = "Seyahat Rehberi", Content = "Keşfedilecek yeni yerler." },
		new Post { Id = 7, UserId = 4, Title = "Sanatın Kalbi", Content = "Sanat dünyasından haberler." },
		new Post { Id = 8, UserId = 5, Title = "Moda Dünyasında Neler Oluyor?", Content = "Moda dünyasının nabzı." },
		new Post { Id = 9, UserId = 6, Title = "Gastronomi Keşifleri", Content = "Gastronomi dünyasından lezzetli haberler." },
		new Post { Id = 10, UserId = 7, Title = "Teknolojik Gelişmeler", Content = "Teknolojideki son gelişmeler ve inovasyonlar." }

	);
			modelBuilder.Entity<User>().HasData(
		new User { Id = 1, Email = "admin@example.com", Password = "123456", Name = "Admin", City = "İstanbul", Phone = "1234567890" },
		new User { Id = 2, Email = "user1@example.com", Password = "123456", Name = "User One", City = "Ankara", Phone = "1234567891" },
		new User { Id = 3, Email = "user2@example.com", Password = "123456", Name = "User Two", City = "İzmir", Phone = "1234567892" },
		new User { Id = 4, Email = "user3@example.com", Password = "123456", Name = "User Three", City = "Antalya", Phone = "1234567893" },
		new User { Id = 5, Email = "user4@example.com", Password = "123456", Name = "User Four", City = "Bursa", Phone = "1234567894" },
		new User { Id = 6, Email = "user5@example.com", Password = "123456", Name = "User Five", City = "Adana", Phone = "1234567895" },
		new User { Id = 7, Email = "user6@example.com", Password = "123456", Name = "User Six", City = "Konya", Phone = "1234567896" },
		new User { Id = 8, Email = "user7@example.com", Password = "123456", Name = "User Seven", City = "Gaziantep", Phone = "1234567897" },
		new User { Id = 9, Email = "user8@example.com", Password = "123456", Name = "User Eight", City = "Samsun", Phone = "1234567898" },
		new User { Id = 10, Email = "user9@example.com", Password = "123456", Name = "User Nine", City = "Kayseri", Phone = "1234567899" }

	);
			modelBuilder.Entity<PostComment>().HasData(
		new PostComment { Id = 1, PostId = 1, UserId = 1, Comment = "Harika bir yazı!", IsActive = true },
		new PostComment { Id = 2, PostId = 1, UserId = 2, Comment = "Çok bilgilendirici, teşekkürler.", IsActive = true },
		new PostComment { Id = 3, PostId = 1, UserId = 3, Comment = "Bu konuda daha fazla bilgi bekliyorum.", IsActive = true },
		new PostComment { Id = 4, PostId = 2, UserId = 4, Comment = "Sporla ilgili bu tür yazıları seviyorum.", IsActive = true },
		new PostComment { Id = 5, PostId = 2, UserId = 5, Comment = "Yazarın bakış açısını beğendim.", IsActive = true },
		new PostComment { Id = 6, PostId = 2, UserId = 6, Comment = "Faydalı bir yazı olmuş.", IsActive = true },
		new PostComment { Id = 7, PostId = 1, UserId = 7, Comment = "Teknolojinin geldiği nokta gerçekten şaşırtıcı.", IsActive = true },
		new PostComment { Id = 8, PostId = 1, UserId = 8, Comment = "Yazar bu konuda çok iyi bilgi sahibi.", IsActive = true },
		new PostComment { Id = 9, PostId = 2, UserId = 9, Comment = "Spor haberlerini takip etmeyi seviyorum.", IsActive = true },
		new PostComment { Id = 10, PostId = 3, UserId = 10, Comment = "Daha fazla spor içeriği görmek isterim.", IsActive = true }

	  );
			modelBuilder.Entity<PostImage>().HasData(
		new PostImage { Id = 2, PostId = 1, ImagePath = "images/post2.jpg" },
		new PostImage { Id = 1, PostId = 1, ImagePath = "images/post1.jpg" },
		new PostImage { Id = 3, PostId = 1, ImagePath = "images/post3.jpg" },
		new PostImage { Id = 4, PostId = 2, ImagePath = "images/post4.jpg" },
		new PostImage { Id = 5, PostId = 2, ImagePath = "images/post5.jpg" },
		new PostImage { Id = 6, PostId = 2, ImagePath = "images/post6.jpg" },
		new PostImage { Id = 7, PostId = 3, ImagePath = "images/post7.jpg" },
		new PostImage { Id = 8, PostId = 3, ImagePath = "images/post8.jpg" },
		new PostImage { Id = 9, PostId = 4, ImagePath = "images/post9.jpg" },
		new PostImage { Id = 10, PostId = 5, ImagePath = "images/post10.jpg" }
	);
			modelBuilder.Entity<Setting>().HasData(
	   new Setting { Id = 1, UserId = 1, Name = "Tema", Value = "Koyu" },
	   new Setting { Id = 2, UserId = 1, Name = "Dil", Value = "Türkçe" },
	   new Setting { Id = 3, UserId = 2, Name = "Tema", Value = "Açık" },
	   new Setting { Id = 4, UserId = 2, Name = "Dil", Value = "İngilizce" },
	   new Setting { Id = 5, UserId = 3, Name = "Tema", Value = "Koyu" },
	   new Setting { Id = 6, UserId = 3, Name = "Dil", Value = "Türkçe" },
	   new Setting { Id = 7, UserId = 4, Name = "Tema", Value = "Açık" },
	   new Setting { Id = 8, UserId = 4, Name = "Dil", Value = "İngilizce" },
	   new Setting { Id = 9, UserId = 5, Name = "Tema", Value = "Koyu" },
	   new Setting { Id = 10, UserId = 5, Name = "Dil", Value = "Türkçe" }
   );
			modelBuilder.Entity<Page>().HasData(
	   new Page { Id = 1, Title = "Hakkımızda", Content = "Bu sayfa şirketimiz hakkında bilgiler içerir.", IsActive = true },
	   new Page { Id = 2, Title = "Misyonumuz", Content = "Şirketimizin misyonunu bu sayfada bulabilirsiniz.", IsActive = true },
	   new Page { Id = 3, Title = "Vizyonumuz", Content = "Gelecek vizyonumuz hakkında bilgi alın.", IsActive = true },
	   new Page { Id = 4, Title = "Kariyer", Content = "Kariyer olanaklarımız hakkında bilgi alın.", IsActive = true },
	   new Page { Id = 5, Title = "İletişim", Content = "Bizimle iletişim bilgileri.", IsActive = true },
	   new Page { Id = 6, Title = "Basın Odası", Content = "Basın bültenlerimiz ve haberler.", IsActive = true },
	   new Page { Id = 7, Title = "Yatırımcı İlişkileri", Content = "Yatırımcılar için önemli bilgiler.", IsActive = true },
	   new Page { Id = 8, Title = "Sosyal Sorumluluk Projeleri", Content = "Topluma katkıda bulunduğumuz projeler.", IsActive = true },
	   new Page { Id = 9, Title = "Sıkça Sorulan Sorular", Content = "Müşterilerimizin sık sorduğu sorular.", IsActive = true },
	   new Page { Id = 10, Title = "Gizlilik Politikası", Content = "Gizlilik ve veri koruma politikamız.", IsActive = true }
	);
			modelBuilder.Entity<CategoryPost>().HasData(
		new CategoryPost { Id = 1, CategoryId = 1, PostId = 1 },
		new CategoryPost { Id = 2, CategoryId = 1, PostId = 2 },
		new CategoryPost { Id = 3, CategoryId = 1, PostId = 3 },
		new CategoryPost { Id = 4, CategoryId = 2, PostId = 4 },
		new CategoryPost { Id = 5, CategoryId = 2, PostId = 5 },
		new CategoryPost { Id = 6, CategoryId = 3, PostId = 6 },
		new CategoryPost { Id = 7, CategoryId = 3, PostId = 7 },
		new CategoryPost { Id = 8, CategoryId = 4, PostId = 8 },
		new CategoryPost { Id = 9, CategoryId = 4, PostId = 9 },
		new CategoryPost { Id = 10, CategoryId = 5, PostId = 10 }
	);

		}
	}
}