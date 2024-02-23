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
    public class BlogImageManager : GenericManager<BlogImage>, IBlogImageService
    {
        private readonly IBlogImageRepository _repository;
        public BlogImageManager(IBlogImageRepository repository) : base(repository)
        {
            _repository=repository;
        }

        public async Task<List<BlogImage>> GetAllBlogImagesByIncludeAsync()
        {
            return await _repository.GetAllBlogImagesByIncludeAsync();
        }

        public async Task<BlogImage> GetBlogImageByIncludeAsync(int id)
        {
            return await _repository.GetBlogImageByIncludeAsync(id);
        }

        public async Task<List<BlogImage>> GetSomeBlogImagesByIncludeAsync(Expression<Func<BlogImage, bool>> expression)
        {
            return await _repository.GetSomeBlogImagesByIncludeAsync(expression);
        }
    }
}
