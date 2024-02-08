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
	public interface IPostCommentRepository : IRepository<PostComment>
	{
		Task<PostComment> GetPostCommentByIncludeAsync(int id);

		Task<List<PostComment>> GetAllPostCommentsByIncludeAsync();

		Task<List<PostComment>> GetSomePostCommentsByIncludeAsync(Expression<Func<PostComment, bool>> expression);
	}
}
