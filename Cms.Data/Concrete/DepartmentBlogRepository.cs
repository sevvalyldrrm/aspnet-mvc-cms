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
	public class DepartmentBlogRepository : Repository<DepartmentBlog, AppDbContext>, IDepartmentBlogRepository
	{
		private readonly AppDbContext _context;

        public DepartmentBlogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DepartmentBlog>> GetAllDepartmentBlogByIncludeAsync()
		{
			return await _context.DepartmentBlogs.Include(d => d.Department).Include(d => d.Blog).ThenInclude(d => d.BlogComments).ThenInclude(d => d.AppUser).ToListAsync();
		}

		public async Task<DepartmentBlog> GetDepartmentBlogByIncludeAsync(int id)
		{
			return await _context.DepartmentBlogs.Include(d => d.Department).Include(d => d.Blog).ThenInclude(d => d.BlogComments).ThenInclude(d => d.AppUser).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<DepartmentBlog>> GetSomeDepartmentBlogByIncludeAsync(Expression<Func<DepartmentBlog, bool>> expression)
		{
			return await _context.DepartmentBlogs.Where(expression).Include(d => d.Department).Include(d => d.Blog).ThenInclude(d => d.BlogComments).ThenInclude(d => d.AppUser).ToListAsync();
		}
	}
}
