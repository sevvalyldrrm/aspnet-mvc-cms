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
	public interface IDepartmentPostService : IGenericService<DepartmentPost>
	{
        Task<DepartmentPost> GetDepartmentPostByIncludeAsync(int id);

        Task<List<DepartmentPost>> GetAllDepartmentPostByIncludeAsync();

        Task<List<DepartmentPost>> GetSomeDepartmentPostByIncludeAsync(Expression<Func<DepartmentPost, bool>> expression);
    }
}
