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
	public class BlogCommentManager : IBlogCommentService
	{
		private readonly IBlogCommentRepository _repository;

		public BlogCommentManager(IBlogCommentRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(BlogComment entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(BlogComment entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<BlogComment> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<BlogComment>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<BlogComment>> GetAllAsync(Expression<Func<BlogComment, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<BlogComment>> GetAllBlogCommentsByIncludeAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<BlogComment> GetAsync(Expression<Func<BlogComment, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<BlogComment> GetBlogCommentByIncludeAsync(int id)
        {
            return await _repository.GetBlogCommentByIncludeAsync(id);
        }

        public async Task<List<BlogComment>> GetSomeBlogCommentsByIncludeAsync(Expression<Func<BlogComment, bool>> expression)
        {
            return await _repository.GetSomeBlogCommentsByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(BlogComment entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
