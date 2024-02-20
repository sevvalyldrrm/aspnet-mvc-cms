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
	public class DoctorRepository : Repository<Doctor, AppDbContext>, IDoctorRepository
	{
		private readonly AppDbContext _context;
		public async Task<List<Doctor>> GetAllDoctorsByIncludeAsync()
		{
			return await _context.Doctors.Include(d => d.DoctorPatients).ThenInclude(dp => dp.Patient).Include(d => d.Department).Include(d => d.Role).ToListAsync();
		}

		public async Task<Doctor> GetDoctorByIncludeAsync(string id)
		{
			return await _context.Doctors.Include(d => d.DoctorPatients).ThenInclude(dp => dp.Patient).Include(d => d.Department).Include(d => d.Role).FirstOrDefaultAsync(p => p.Id == id);

			
		}

		public async Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression)
		{
			return await _context.Doctors.Where(expression).Include(d => d.DoctorPatients).ThenInclude(dp => dp.Patient).Include(d => d.Role).Include(d => d.Department).ToListAsync();
		}
     

    }
}
