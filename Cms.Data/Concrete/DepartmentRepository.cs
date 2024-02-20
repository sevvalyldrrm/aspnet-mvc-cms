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
	public class DepartmentRepository : Repository<Department, AppDbContext>, IDepartmentRepository
	{
		private readonly AppDbContext _context;

		public async Task<List<Department>> GetAllDepartmentByIncludeAsync()
		{
			return await _context.Departments.Include(d => d.Doctor).ToListAsync();
		}

		public async Task<Department> GetDepartmentByIncludeAsync(int id)
		{
			return await _context.Departments.Include(d => d.Doctor).FirstOrDefaultAsync(d => d.Id == id);
		}

		public Task<List<Department>> GetSomeDepartmentByIncludeAsync(Expression<Func<Department, bool>> expression)
		{
			return _context.Departments.Where(expression).Include(d => d.Doctor).ToListAsync();
		}

	}
}
