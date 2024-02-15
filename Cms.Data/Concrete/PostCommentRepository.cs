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
	public class PostCommentRepository : Repository<PostComment, AppDbContext>, IPostCommentRepository
	{
		private readonly AppDbContext _context;
		public async Task<List<PostComment>> GetAllPostCommentsByIncludeAsync()
		{
			return await _context.PostComments.Include(p => p.AppUser).Include(p => p.Post).ToListAsync();

		}

		public async Task<PostComment> GetPostCommentByIncludeAsync(int id)
		{
			return await _context.PostComments.Include(p => p.AppUser).Include(p => p.Post).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<PostComment>> GetSomePostCommentsByIncludeAsync(Expression<Func<PostComment, bool>> expression)
		{
			return await _context.PostComments.Where(expression).Include(p => p.AppUser).Include(p => p.Post).ToListAsync();
		}
	}
}
