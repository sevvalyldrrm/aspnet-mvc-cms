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
	public class DepartmentBlogManager : IDepartmentBlogService
	{
		private readonly IDepartmentBlogRepository _repository;

		public DepartmentBlogManager(IDepartmentBlogRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(DepartmentBlog entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(DepartmentBlog entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<DepartmentBlog> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<DepartmentBlog>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<DepartmentBlog>> GetAllAsync(Expression<Func<DepartmentBlog, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<DepartmentBlog>> GetAllDepartmentBlogByIncludeAsync()
        {
            return await _repository.GetAllDepartmentBlogByIncludeAsync();
        }

        public async Task<DepartmentBlog> GetAsync(Expression<Func<DepartmentBlog, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<DepartmentBlog> GetDepartmentBlogByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentBlogByIncludeAsync(id); 
        }

        public async Task<List<DepartmentBlog>> GetSomeDepartmentBlogByIncludeAsync(Expression<Func<DepartmentBlog, bool>> expression)
        {
            return await _repository.GetSomeDepartmentBlogByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(DepartmentBlog entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
