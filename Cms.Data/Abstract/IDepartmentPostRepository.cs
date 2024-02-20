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
	public interface IDepartmentPostRepository : IRepository<DepartmentPost>
	{
		Task<DepartmentPost> GetDepartmentPostByIncludeAsync(int id);

		Task<List<DepartmentPost>> GetAllDepartmentPostByIncludeAsync();

		Task<List<DepartmentPost>> GetSomeDepartmentPostByIncludeAsync(Expression<Func<DepartmentPost, bool>> expression);
	}
}
