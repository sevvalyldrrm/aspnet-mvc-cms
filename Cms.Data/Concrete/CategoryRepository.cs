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
	public class CategoryRepository : Repository<Category, AppDbContext>, ICategoryRepository
	{
		private readonly AppDbContext _context;

		public async Task<List<Category>> GetAllCategoryByIncludeAsync()
		{
			return await _context.Categories.Include(d => d.Doctor).ToListAsync();
		}

		public async Task<Category> GetCategoryByIncludeAsync(int id)
		{
			return await _context.Categories.Include(d => d.Doctor).FirstOrDefaultAsync(d => d.Id == id);
		}

		public Task<List<Category>> GetSomeCategoryByIncludeAsync(Expression<Func<Category, bool>> expression)
		{
			return _context.Categories.Where(expression).Include(d => d.Doctor).ToListAsync();
		}

	}
}
