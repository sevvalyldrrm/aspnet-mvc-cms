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
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AppointmentManager> AppointmentManagers { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<DepartmentBlog> DepartmentBlogs { get; set; }
		public DbSet<DepartmentDetail> DepartmentDetails { get; set; }
		public DbSet<BlogImage> BlogImages { get; set; }
		public DbSet<BlogComment> BlogComments { get; set; }		
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }		
		public DbSet<DoctorPatient> DoctorPatients { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Introduction> Introductions { get; set; }
		public DbSet<WorkingHour> WorkingHours { get; set; }
		public DbSet<Surgery> Surgeries { get; set; }

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
			modelBuilder.Entity<Blog>().HasData(
		new Blog { Id = 1, AppUserId = 1, Title = "Yeni Teknolojiler", Content = "Yeni teknolojiler hakkında bilgiler." },
		new Blog { Id = 2, AppUserId = 1, Title = "Spor Dünyası", Content = "Spor dünyasından son gelişmeler." },
		new Blog { Id = 3, AppUserId = 9, Title = "Sağlıklı Yaşam", Content = "Sağlıklı yaşam için ipuçları." },
		new Blog { Id = 4, AppUserId = 2, Title = "Eğitimde Yenilikler", Content = "Eğitim alanında yaşanan son gelişmeler." },
		new Blog { Id = 5, AppUserId = 8, Title = "Ekonomi Analizi", Content = "Dünya ekonomisine genel bir bakış." },
		new Blog { Id = 6, AppUserId = 3, Title = "Seyahat Rehberi", Content = "Keşfedilecek yeni yerler." },
		new Blog { Id = 7, AppUserId = 4, Title = "Sanatın Kalbi", Content = "Sanat dünyasından haberler." },
		new Blog { Id = 8, AppUserId = 5, Title = "Moda Dünyasında Neler Oluyor?", Content = "Moda dünyasının nabzı." },
		new Blog { Id = 9, AppUserId = 6, Title = "Gastronomi Keşifleri", Content = "Gastronomi dünyasından lezzetli haberler." },
		new Blog { Id = 10, AppUserId = 7, Title = "Teknolojik Gelişmeler", Content = "Teknolojideki son gelişmeler ve inovasyonlar." }

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
			modelBuilder.Entity<BlogComment>().HasData(
		new BlogComment { Id = 1, BlogId = 1,  Comment = "Harika bir yazı!", IsActive = true },
		new BlogComment { Id = 2, BlogId = 1,  Comment = "Çok bilgilendirici, teşekkürler.", IsActive = true },
		new BlogComment { Id = 3, BlogId = 1,  Comment = "Bu konuda daha fazla bilgi bekliyorum.", IsActive = true },
		new BlogComment { Id = 4, BlogId = 2,  Comment = "Sporla ilgili bu tür yazıları seviyorum.", IsActive = true },
		new BlogComment { Id = 5, BlogId = 2,  Comment = "Yazarın bakış açısını beğendim.", IsActive = true },
		new BlogComment { Id = 6, BlogId = 2,  Comment = "Faydalı bir yazı olmuş.", IsActive = true },
		new BlogComment { Id = 7, BlogId = 1,  Comment = "Teknolojinin geldiği nokta gerçekten şaşırtıcı.", IsActive = true },
		new BlogComment { Id = 8, BlogId = 1,  Comment = "Yazar bu konuda çok iyi bilgi sahibi.", IsActive = true },
		new BlogComment { Id = 9, BlogId = 2,  Comment = "Spor haberlerini takip etmeyi seviyorum.", IsActive = true },
		new BlogComment { Id = 10, BlogId = 3, Comment = "Daha fazla spor içeriği görmek isterim.", IsActive = true }

	  );
			modelBuilder.Entity<BlogImage>().HasData(
		new BlogImage { Id = 2, BlogId = 1, ImagePath = "images/Blog2.jpg" },
		new BlogImage { Id = 1, BlogId = 1, ImagePath = "images/Blog1.jpg" },
		new BlogImage { Id = 3, BlogId = 1, ImagePath = "images/Blog3.jpg" },
		new BlogImage { Id = 4, BlogId = 2, ImagePath = "images/Blog4.jpg" },
		new BlogImage { Id = 5, BlogId = 2, ImagePath = "images/Blog5.jpg" },
		new BlogImage { Id = 6, BlogId = 2, ImagePath = "images/Blog6.jpg" },
		new BlogImage { Id = 7, BlogId = 3, ImagePath = "images/Blog7.jpg" },
		new BlogImage { Id = 8, BlogId = 3, ImagePath = "images/Blog8.jpg" },
		new BlogImage { Id = 9, BlogId = 4, ImagePath = "images/Blog9.jpg" },
		new BlogImage { Id = 10, BlogId = 5, ImagePath = "images/Blog10.jpg" }
	);
						
			modelBuilder.Entity<DepartmentBlog>().HasData(
		new DepartmentBlog { Id = 1, DepartmentId = 1, BlogId = 1 },
		new DepartmentBlog { Id = 2, DepartmentId = 1, BlogId = 2 },
		new DepartmentBlog { Id = 3, DepartmentId = 1, BlogId = 3 },
		new DepartmentBlog { Id = 4, DepartmentId = 2, BlogId = 4 },
		new DepartmentBlog { Id = 5, DepartmentId = 2, BlogId = 5 },
		new DepartmentBlog { Id = 6, DepartmentId = 3, BlogId = 6 },
		new DepartmentBlog { Id = 7, DepartmentId = 3, BlogId = 7 },
		new DepartmentBlog { Id = 8, DepartmentId = 4, BlogId = 8 },
		new DepartmentBlog { Id = 9, DepartmentId = 4, BlogId = 9 },
		new DepartmentBlog { Id = 10, DepartmentId = 5, BlogId = 10 }
	);

		}
	}
}
