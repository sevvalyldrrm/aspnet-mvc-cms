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
	public class PostRepository : Repository<Post, AppDbContext>, IPostRepository
	{
		private readonly AppDbContext _context;
		public async Task<List<Post>> GetAllPostsByIncludeAsync()
		{
			return await _context.Posts.Include(x => x.PostComments).AsNoTracking().ToListAsync();
		}

		public async Task<Post> GetPostByIncludeAsync(int id)
		{
			return await _context.Posts.Include(x => x.PostComments).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<Post>> GetSomePostsByIncludeAsync(Expression<Func<Post, bool>> expression)
		{
			return await _context.Posts.Include(x => x.PostComments).AsNoTracking().Where(expression).ToListAsync();
		}
	}
}
