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
	public class DepartmentBlogManager : GenericManager<DepartmentBlog>,IDepartmentBlogService
	{
		private readonly IDepartmentBlogRepository _repository;

		public DepartmentBlogManager(IDepartmentBlogRepository repository) : base(repository)
        {
			_repository = repository;
		}

        public async Task<List<DepartmentBlog>> GetAllDepartmentBlogByIncludeAsync()
        {
            return await _repository.GetAllDepartmentBlogByIncludeAsync();
        }

        public async Task<DepartmentBlog> GetDepartmentBlogByIncludeAsync(int id)
        {
            return await _repository.GetDepartmentBlogByIncludeAsync(id);
        }

        public async Task<List<DepartmentBlog>> GetSomeDepartmentBlogByIncludeAsync(Expression<Func<DepartmentBlog, bool>> expression)
        {
            return await _repository.GetSomeDepartmentBlogByIncludeAsync(expression);
        }
    }
}
