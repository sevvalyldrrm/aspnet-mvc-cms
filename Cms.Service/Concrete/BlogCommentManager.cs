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
	public class BlogCommentManager : GenericManager<BlogComment>,IBlogCommentService
	{
		private readonly IBlogCommentRepository _repository;

		public BlogCommentManager(IBlogCommentRepository repository) : base(repository)
        {
			_repository = repository;
		}

        public async Task<List<BlogComment>> GetAllBlogCommentsByIncludeAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<BlogComment> GetBlogCommentByIncludeAsync(int id)
        {
            return await _repository.GetBlogCommentByIncludeAsync(id);
        }

        public async Task<List<BlogComment>> GetSomeBlogCommentsByIncludeAsync(Expression<Func<BlogComment, bool>> expression)
        {
            return await _repository.GetSomeBlogCommentsByIncludeAsync(expression);
        }

       
	}
}
