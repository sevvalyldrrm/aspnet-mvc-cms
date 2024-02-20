using Cms.Data.Abstract;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
	public interface IPostService : IGenericService<Post>
	{
        Task<Post> GetPostByIncludeAsync(int id);

        Task<List<Post>> GetAllPostsByIncludeAsync();

        Task<List<Post>> GetSomePostsByIncludeAsync(Expression<Func<Post, bool>> expression);
    }
}
