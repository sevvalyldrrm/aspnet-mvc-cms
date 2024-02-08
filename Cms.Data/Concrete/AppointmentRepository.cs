using Cms.Data.Abstract;
using Cms.Data.DataContext;
using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Concrete
{
	public class AppointmentRepository : Repository<Appointment,AppDbContext>, IAppointmentRepository
	{
		private readonly AppDbContext _context;

		public async Task<List<Appointment>> GetAllAppointmentsByIncludeAsync()
		{
			return await _context.Appointments.Include(a => a.Doctor).Include(a => a.Category).ToListAsync();

			//return await _context.Appointments.Select(x => new Doctor
			//{
			//	FullName = x.FullName
			//}).ToListAsync();
		}

		public async Task<Appointment> GetAppointmentByIncludeAsync(int id)
		{
			return await _context.Appointments.Include(a => a.Doctor).Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
		}

		public async Task<List<Appointment>> GetSomeAppointmentsByIncludeAsync(Expression<Func<Appointment, bool>> expression)
		{
			return await _context.Appointments.Where(expression).Include(a => a.Doctor).Include(a => a.Category).ToListAsync();
		}
	}
}