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
	public class CategoryPostManager : ICategoryPostService
	{
		private readonly ICategoryPostRepository _repository;

		public CategoryPostManager(ICategoryPostRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(CategoryPost entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(CategoryPost entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<CategoryPost> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<CategoryPost>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<CategoryPost>> GetAllAsync(Expression<Func<CategoryPost, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

		public async Task<CategoryPost> GetAsync(Expression<Func<CategoryPost, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

		public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(CategoryPost entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
