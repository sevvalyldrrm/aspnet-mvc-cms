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
	public interface ICategoryPostService : IGenericService<CategoryPost>
	{
        Task<CategoryPost> GetCategoryPostByIncludeAsync(int id);

        Task<List<CategoryPost>> GetAllCategoryPostByIncludeAsync();

        Task<List<CategoryPost>> GetSomeCategoryPostByIncludeAsync(Expression<Func<CategoryPost, bool>> expression);
    }
}
