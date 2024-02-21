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
		public async Task<List<Blog>> GetAllBlogsByIncludeAsync()
		{
			return await _context.Blogs.Include(x => x.BlogComments).AsNoTracking().ToListAsync();
		}

		public async Task<Blog> GetBlogByIncludeAsync(int id)
		{
			return await _context.Blogs.Include(x => x.BlogComments).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression)
		{
			return await _context.Blogs.Include(x => x.BlogComments).AsNoTracking().Where(expression).ToListAsync();
		}
	}
}
