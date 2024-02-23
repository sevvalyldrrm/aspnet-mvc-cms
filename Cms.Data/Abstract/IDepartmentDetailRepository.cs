using Cms.Data.Concrete;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
    public interface IDepartmentDetailRepository : IRepository<DepartmentDetail>
    {
        Task<DepartmentDetail> GetDepartmentDetailByIncludeAsync(int id);

        Task<List<DepartmentDetail>> GetAllDepartmentDetailsByIncludeAsync();

        Task<List<DepartmentDetail>> GetSomeDepartmentDetailsByIncludeAsync(Expression<Func<DepartmentDetail, bool>> expression);
    }
}
