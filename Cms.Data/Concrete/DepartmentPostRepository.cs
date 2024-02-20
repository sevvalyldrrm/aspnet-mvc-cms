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
	public class DepartmentPostRepository : Repository<DepartmentPost, AppDbContext>, IDepartmentPostRepository
	{
		private readonly AppDbContext _context;

		public async Task<List<DepartmentPost>> GetAllDepartmentPostByIncludeAsync()
		{
			return await _context.DepartmentPosts.Include(d => d.Department).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).ToListAsync();
		}

		public async Task<DepartmentPost> GetDepartmentPostByIncludeAsync(int id)
		{
			return await _context.DepartmentPosts.Include(d => d.Department).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<DepartmentPost>> GetSomeDepartmentPostByIncludeAsync(Expression<Func<DepartmentPost, bool>> expression)
		{
			return await _context.DepartmentPosts.Where(expression).Include(d => d.Department).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).ToListAsync();
		}
	}
}
