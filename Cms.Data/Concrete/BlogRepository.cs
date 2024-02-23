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
	public class BlogRepository : Repository<Blog, AppDbContext>, IBlogRepository
	{
		private readonly AppDbContext _context;

        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetAllBlogsByIncludeAsync()
		{
			return await _context.Blogs.Include(x => x.AppUser).Include(x => x.BlogComments).Include(x => x.BlogImages).Include(x => x.DepartmentBlogs).AsNoTracking().ToListAsync();
		}

		public async Task<Blog> GetBlogByIncludeAsync(int id)
		{
			return await _context.Blogs.Include(x => x.AppUser).Include(x => x.BlogComments).Include(x => x.BlogImages).Include(x => x.DepartmentBlogs).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression)
		{
			return await _context.Blogs.Include(x => x.AppUser).Include(x => x.BlogComments).Include(x => x.BlogImages).Include(x => x.DepartmentBlogs).AsNoTracking().Where(expression).ToListAsync();
		}
	}
}
