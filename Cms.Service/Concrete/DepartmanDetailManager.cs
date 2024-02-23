using Cms.Data.Entity;
using Cms.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
    public class DepartmanDetailManager : IDepartmentDetailService
    {
        public Task AddAsync(DepartmentDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DepartmentDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDetail> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDetail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDetail>> GetAllAsync(Expression<Func<DepartmentDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDetail>> GetAllDepartmentDetailsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDetail> GetAsync(Expression<Func<DepartmentDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentDetail> GetDepartmentDetailByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentDetail>> GetSomeDepartmentDetailsByIncludeAsync(Expression<Func<DepartmentDetail, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DepartmentDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
