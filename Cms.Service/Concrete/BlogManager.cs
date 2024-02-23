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
	public class BlogManager : GenericManager<Blog>,IBlogService
	{
		private readonly IBlogRepository _repository;

		public BlogManager(IBlogRepository repository) : base(repository)
        {
			_repository = repository;
		}
        public async Task<List<Blog>> GetAllBlogsByIncludeAsync()
        {
            return await _repository.GetAllBlogsByIncludeAsync();
        }

      
        public async Task<Blog> GetBlogByIncludeAsync(int id)
        {
            return await _repository.GetBlogByIncludeAsync(id);
        }

        public async Task<List<Blog>> GetSomeBlogsByIncludeAsync(Expression<Func<Blog, bool>> expression)
        {
            return await _repository.GetSomeBlogsByIncludeAsync(expression);
        }
	}
}
