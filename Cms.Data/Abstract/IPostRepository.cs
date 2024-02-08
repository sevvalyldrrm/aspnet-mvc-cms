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
	public interface IPostRepository : IRepository<Post>
	{
		Task<Post> GetPostByIncludeAsync(int id);

		Task<List<Post>> GetAllPostsByIncludeAsync();

		Task<List<Post>> GetSomePostsByIncludeAsync(Expression<Func<Post, bool>> expression);
	}
}
