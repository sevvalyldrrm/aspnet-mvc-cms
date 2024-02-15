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
	public class PostCommentManager : IPostCommentService
	{
		private readonly IPostCommentRepository _repository;

		public PostCommentManager(IPostCommentRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(PostComment entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(PostComment entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<PostComment> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<PostComment>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<PostComment>> GetAllAsync(Expression<Func<PostComment, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

		public async Task<PostComment> GetAsync(Expression<Func<PostComment, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

		public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(PostComment entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
