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
	public class DepartmentPostManager : IDepartmentPostService
	{
		private readonly IDepartmentPostRepository _repository;

		public DepartmentPostManager(IDepartmentPostRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(DepartmentPost entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(DepartmentPost entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<DepartmentPost> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<DepartmentPost>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<DepartmentPost>> GetAllAsync(Expression<Func<DepartmentPost, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<DepartmentPost>> GetAllDepartmentPostByIncludeAsync()
        {
            return await _repository.GetAllDepartmentPostByIncludeAsync();
        }

        public async Task<DepartmentPost> GetAsync(Expression<Func<DepartmentPost, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<DepartmentPost> GetDepartmentPostByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentPostByIncludeAsync(id); 
        }

        public async Task<List<DepartmentPost>> GetSomeDepartmentPostByIncludeAsync(Expression<Func<DepartmentPost, bool>> expression)
        {
            return await _repository.GetSomeDepartmentPostByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(DepartmentPost entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
