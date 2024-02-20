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
	public class PostManager : IPostService
	{
		private readonly IPostRepository _repository;

		public PostManager(IPostRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Post entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Post entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Post> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Post>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Post>> GetAllAsync(Expression<Func<Post, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Post>> GetAllPostsByIncludeAsync()
        {
            return await _repository.GetAllPostsByIncludeAsync();
        }

        public async Task<Post> GetAsync(Expression<Func<Post, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Post> GetPostByIncludeAsync(int id)
        {
            return await _repository.GetPostByIncludeAsync(id);
        }

        public async Task<List<Post>> GetSomePostsByIncludeAsync(Expression<Func<Post, bool>> expression)
        {
            return await _repository.GetSomePostsByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Post entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
