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
	public class CategoryPostRepository : Repository<CategoryPost, AppDbContext>, ICategoryPostRepository
	{
		private readonly AppDbContext _context;

		public async Task<List<CategoryPost>> GetAllCategoryPostByIncludeAsync()
		{
			return await _context.CategoryPosts.Include(d => d.Category).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).ToListAsync();
		}

		public async Task<CategoryPost> GetCategoryPostByIncludeAsync(int id)
		{
			return await _context.CategoryPosts.Include(d => d.Category).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<CategoryPost>> GetSomeCategoryPostByIncludeAsync(Expression<Func<CategoryPost, bool>> expression)
		{
			return await _context.CategoryPosts.Where(expression).Include(d => d.Category).Include(d => d.Post).ThenInclude(d => d.PostComments).ThenInclude(d => d.AppUser).ToListAsync();
		}
	}
}
