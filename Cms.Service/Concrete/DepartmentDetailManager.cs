using Cms.Data.Abstract;
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
    public class DepartmentDetailManager : GenericManager<DepartmentDetail>,IDepartmentDetailService
    {
       private readonly IDepartmentDetailRepository _repository;
        public DepartmentDetailManager(IDepartmentDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<DepartmentDetail>> GetAllDepartmentDetailsByIncludeAsync()
        {
            return await _repository.GetAllDepartmentDetailsByIncludeAsync();
        }

        public async Task<DepartmentDetail> GetDepartmentDetailByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentDetailByIncludeAsync(id);
        }

        public async Task<List<DepartmentDetail>> GetSomeDepartmentDetailsByIncludeAsync(Expression<Func<DepartmentDetail, bool>> expression)
        {
            return await _repository.GetSomeDepartmentDetailsByIncludeAsync(expression);
        }
    }
}
