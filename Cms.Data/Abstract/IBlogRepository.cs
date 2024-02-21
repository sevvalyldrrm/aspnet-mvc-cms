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
	public interface IBlogRepository : IRepository<Blog>
	{
		Task<Blog> GetBlogByIncludeAsync(int id);

		Task<List<Blog>> GetAllBlogsByIncludeAsync();

		Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression);
	}
}
