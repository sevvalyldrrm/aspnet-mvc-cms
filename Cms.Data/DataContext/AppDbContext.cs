using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.DataContext
{
	public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
	{
		
		public AppDbContext() { }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}

		
		
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<DepartmentPost> DepartmentPosts { get; set; }
		public DbSet<PostImage> PostImages { get; set; }
		public DbSet<PostComment> PostComments { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Setting> Settings { get; set; }
		public DbSet<Setting> DoctorPatients { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Introduction> Introductions { get; set; }
		public DbSet<WorkingHour> WorkingHours { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
		new Department { Id = 1, Name = "Teknoloji", Description = "Teknoloji ile ilgili haberler" },
		new Department { Id = 2, Name = "Spor", Description = "Spor haberleri" },
		new Department { Id = 3, Name = "Sağlık", Description = "Sağlık ve yaşam tarzı ile ilgili bilgiler" },
		new Department { Id = 4, Name = "Eğitim", Description = "Eğitim dünyasından haberler ve ipuçları" },
		new Department { Id = 5, Name = "Ekonomi", Description = "Ekonomi ve finans dünyasına dair güncel bilgiler" },
		new Department { Id = 6, Name = "Seyahat", Description = "Seyahat ipuçları ve destinasyon önerileri" },
		new Department { Id = 7, Name = "Sanat", Description = "Sanat dünyasından son gelişmeler" },
		new Department { Id = 8, Name = "Moda", Description = "Moda dünyasından en son trendler" },
		new Department { Id = 9, Name = "Gastronomi", Description = "Yemek kültürü ve gastronomi haberleri" },
		new Department { Id = 10, Name = "Teknoloji Yenilikleri", Description = "Teknolojideki son yenilikler ve icatlar" }

	);
			modelBuilder.Entity<Post>().HasData(
		new Post { Id = 1, AppUserId = 1, Title = "Yeni Teknolojiler", Content = "Yeni teknolojiler hakkında bilgiler." },
		new Post { Id = 2, AppUserId = 1, Title = "Spor Dünyası", Content = "Spor dünyasından son gelişmeler." },
		new Post { Id = 3, AppUserId = 9, Title = "Sağlıklı Yaşam", Content = "Sağlıklı yaşam için ipuçları." },
		new Post { Id = 4, AppUserId = 2, Title = "Eğitimde Yenilikler", Content = "Eğitim alanında yaşanan son gelişmeler." },
		new Post { Id = 5, AppUserId = 8, Title = "Ekonomi Analizi", Content = "Dünya ekonomisine genel bir bakış." },
		new Post { Id = 6, AppUserId = 3, Title = "Seyahat Rehberi", Content = "Keşfedilecek yeni yerler." },
		new Post { Id = 7, AppUserId = 4, Title = "Sanatın Kalbi", Content = "Sanat dünyasından haberler." },
		new Post { Id = 8, AppUserId = 5, Title = "Moda Dünyasında Neler Oluyor?", Content = "Moda dünyasının nabzı." },
		new Post { Id = 9, AppUserId = 6, Title = "Gastronomi Keşifleri", Content = "Gastronomi dünyasından lezzetli haberler." },
		new Post { Id = 10, AppUserId = 7, Title = "Teknolojik Gelişmeler", Content = "Teknolojideki son gelişmeler ve inovasyonlar." }

	);

			modelBuilder.Entity<AppRole>().HasData(new AppRole
			{
				Id = "1",
				Name = "Admin",
				NormalizedName = "ADMIN"
			},
			new AppRole
			{
				Id = "2",
				Name = "Doctor",
				NormalizedName = "DOCTOR"
			},
			new AppRole
			{
				Id = "3",
				Name = "Patient",
				NormalizedName = "PATIENT"
			});

			modelBuilder.Entity<AppUser>().HasData(
		new AppUser { FullName = "Admin", City = "İstanbul" },
		new AppUser { FullName = "User One", City = "Ankara" },
		new AppUser { FullName = "User Two", City = "İzmir" },
		new AppUser { FullName = "User Three", City = "Antalya" },
		new AppUser { FullName = "User Four", City = "Bursa" },
		new AppUser { FullName = "User Five", City = "Adana" },
		new AppUser { FullName = "User Six", City = "Konya" },
		new AppUser { FullName = "User Seven", City = "Gaziantep" },
		new AppUser { FullName = "User Eight", City = "Samsun" },
		new AppUser { FullName = "User Nine", City = "Kayseri" }

	);
			modelBuilder.Entity<PostComment>().HasData(
		new PostComment { Id = 1, PostId = 1,  Comment = "Harika bir yazı!", IsActive = true },
		new PostComment { Id = 2, PostId = 1,  Comment = "Çok bilgilendirici, teşekkürler.", IsActive = true },
		new PostComment { Id = 3, PostId = 1,  Comment = "Bu konuda daha fazla bilgi bekliyorum.", IsActive = true },
		new PostComment { Id = 4, PostId = 2,  Comment = "Sporla ilgili bu tür yazıları seviyorum.", IsActive = true },
		new PostComment { Id = 5, PostId = 2,  Comment = "Yazarın bakış açısını beğendim.", IsActive = true },
		new PostComment { Id = 6, PostId = 2,  Comment = "Faydalı bir yazı olmuş.", IsActive = true },
		new PostComment { Id = 7, PostId = 1,  Comment = "Teknolojinin geldiği nokta gerçekten şaşırtıcı.", IsActive = true },
		new PostComment { Id = 8, PostId = 1,  Comment = "Yazar bu konuda çok iyi bilgi sahibi.", IsActive = true },
		new PostComment { Id = 9, PostId = 2,  Comment = "Spor haberlerini takip etmeyi seviyorum.", IsActive = true },
		new PostComment { Id = 10, PostId = 3, Comment = "Daha fazla spor içeriği görmek isterim.", IsActive = true }

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
			modelBuilder.Entity<DepartmentPost>().HasData(
		new DepartmentPost { Id = 1, DepartmentId = 1, PostId = 1 },
		new DepartmentPost { Id = 2, DepartmentId = 1, PostId = 2 },
		new DepartmentPost { Id = 3, DepartmentId = 1, PostId = 3 },
		new DepartmentPost { Id = 4, DepartmentId = 2, PostId = 4 },
		new DepartmentPost { Id = 5, DepartmentId = 2, PostId = 5 },
		new DepartmentPost { Id = 6, DepartmentId = 3, PostId = 6 },
		new DepartmentPost { Id = 7, DepartmentId = 3, PostId = 7 },
		new DepartmentPost { Id = 8, DepartmentId = 4, PostId = 8 },
		new DepartmentPost { Id = 9, DepartmentId = 4, PostId = 9 },
		new DepartmentPost { Id = 10, DepartmentId = 5, PostId = 10 }
	);

		}
	}
}
