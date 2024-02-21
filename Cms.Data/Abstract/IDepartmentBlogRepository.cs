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
	public interface IDepartmentBlogRepository : IRepository<DepartmentBlog>
	{
		Task<DepartmentBlog> GetDepartmentBlogByIncludeAsync(int id);

		Task<List<DepartmentBlog>> GetAllDepartmentBlogByIncludeAsync();

		Task<List<DepartmentBlog>> GetSomeDepartmentBlogByIncludeAsync(Expression<Func<DepartmentBlog, bool>> expression);
	}
}
