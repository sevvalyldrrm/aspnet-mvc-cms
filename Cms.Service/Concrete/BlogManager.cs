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
	public class BlogManager : IBlogService
	{
		private readonly IBlogRepository _repository;

		public BlogManager(IBlogRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Blog entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Blog entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Blog> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Blog>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Blog>> GetAllAsync(Expression<Func<Blog, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Blog>> GetAllBlogsByIncludeAsync()
        {
            return await _repository.GetAllBlogsByIncludeAsync();
        }

        public async Task<Blog> GetAsync(Expression<Func<Blog, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Blog> GetBlogByIncludeAsync(int id)
        {
            return await _repository.GetBlogByIncludeAsync(id);
        }

        public async Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression)
        {
            return await _repository.GetSomeBlogsByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Blog entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
