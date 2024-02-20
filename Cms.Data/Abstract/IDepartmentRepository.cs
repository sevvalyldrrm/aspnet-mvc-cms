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
	public interface IDepartmentRepository : IRepository<Department>
	{
		Task<Department> GetDepartmentByIncludeAsync(int id);

		Task<List<Department>> GetAllDepartmentByIncludeAsync();

		Task<List<Department>> GetSomeDepartmentByIncludeAsync(Expression<Func<Department, bool>> expression);
	}
}
