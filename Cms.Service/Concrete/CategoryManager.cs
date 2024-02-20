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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryRepository _repository;

		public CategoryManager(ICategoryRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Category entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Category entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Category> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Category>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Category>> GetAllCategoryByIncludeAsync()
        {
            return await _repository.GetAllCategoryByIncludeAsync();
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Category> GetCategoryByIncludeAsync(int id)
        {
            return await _repository.GetCategoryByIncludeAsync(id);
        }

        public async Task<List<Category>> GetSomeCategoryByIncludeAsync(Expression<Func<Category, bool>> expression)
        {
            return await _repository.GetSomeCategoryByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Category entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
