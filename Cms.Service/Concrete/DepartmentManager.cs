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
	public class DepartmentManager : IDepartmentService
	{
		private readonly IDepartmentRepository _repository;

		public DepartmentManager(IDepartmentRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Department entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Department entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Department> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Department>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Department>> GetAllAsync(Expression<Func<Department, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Department>> GetAllDepartmentByIncludeAsync()
        {
            return await _repository.GetAllDepartmentByIncludeAsync();
        }

        public async Task<Department> GetAsync(Expression<Func<Department, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Department> GetDepartmentByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentByIncludeAsync(id);
        }

        public async Task<List<Department>> GetSomeDepartmentByIncludeAsync(Expression<Func<Department, bool>> expression)
        {
            return await _repository.GetSomeDepartmentByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Department entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
