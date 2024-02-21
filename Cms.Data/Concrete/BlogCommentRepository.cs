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
	public class BlogCommentRepository : Repository<BlogComment, AppDbContext>, IBlogCommentRepository
	{
		private readonly AppDbContext _context;
		public async Task<List<BlogComment>> GetAllBlogCommentsByIncludeAsync()
		{
			return await _context.BlogComments.Include(p => p.AppUser).Include(p => p.Blog).ToListAsync();

		}

		public async Task<BlogComment> GetBlogCommentByIncludeAsync(int id)
		{
			return await _context.BlogComments.Include(p => p.AppUser).Include(p => p.Blog).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<BlogComment>> GetSomeBlogCommentsByIncludeAsync(Expression<Func<BlogComment, bool>> expression)
		{
			return await _context.BlogComments.Where(expression).Include(p => p.AppUser).Include(p => p.Blog).ToListAsync();
		}
	}
}
