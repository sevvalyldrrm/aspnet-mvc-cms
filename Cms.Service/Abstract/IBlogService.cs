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
	public interface IBlogService : IGenericService<Blog>
	{
        Task<Blog> GetBlogByIncludeAsync(int id);

        Task<List<Blog>> GetAllBlogsByIncludeAsync();

        Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression);
    }
}
