using Cms.Data.Entity;
using Cms.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
	public interface IBlogCommentRepository : IRepository<BlogComment>
	{
		Task<BlogComment> GetBlogCommentByIncludeAsync(int id);

		Task<List<BlogComment>> GetAllBlogCommentsByIncludeAsync();

		Task<List<BlogComment>> GetSomeBlogCommentsByIncludeAsync(Expression<Func<BlogComment, bool>> expression);
	}
}
