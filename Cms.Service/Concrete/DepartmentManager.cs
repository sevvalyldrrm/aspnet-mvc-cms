using Cms.Data.Abstract;
using Cms.Data.Entity;
using Cms.Service.Abstract;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
	public class DepartmentManager :GenericManager<Department> ,IDepartmentService
	{
		private readonly IDepartmentRepository _repository;

		public DepartmentManager(IDepartmentRepository repository) : base(repository) //Burası genel mi? Burayı silip tekrar bakalım.
        {
			_repository = repository;
		}

        public async Task<List<Department>> GetAllDepartmentByIncludeAsync()
        {
            return await _repository.GetAllDepartmentByIncludeAsync();
        }

        public async Task<Department> GetDepartmentByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentByIncludeAsync(id);
        }

        public async Task<List<Department>> GetSomeDepartmentByIncludeAsync(Expression<Func<Department, bool>> expression)
        {
            return await _repository.GetSomeDepartmentByIncludeAsync(expression);
        }
    }
}
