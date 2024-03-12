using Hospital.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Persistence.Context
{
	public class AppDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-0LP7T25\\SQL2022;Initial Catalog=Hotelier;Persist Security Info=True;User ID=sa;Password=123;Trusted_Connection=True; TrustServerCertificate=Yes");
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
		public DbSet<SurgeryDoctor> SurgeryDoctors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		modelBuilder.Entity<Department>()
			 .HasOne(d => d.DepartmentDetails) // Department sınıfındaki navigasyon özelliği
			 .WithOne(dd => dd.Departments) // DepartmentDetail sınıfındaki karşılıklı navigasyon özelliği
			 .HasForeignKey<DepartmentDetail>(dd => dd.DepartmentId); // DepartmentDetail içindeki yabancı anahtar özelliği

		modelBuilder.Entity<Doctor>()
			 .HasOne(d => d.Introduction) // Doctor sınıfındaki navigasyon özelliği
			 .WithOne(i => i.Doctor) // Introduction sınıfındaki navigasyon özelliği
			 .HasForeignKey<Introduction>(i => i.DoctorId); // Introduction içindeki yabancı anahtar
		}


	}
}
