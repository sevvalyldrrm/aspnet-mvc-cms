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
        public BlogImageManager(IRepository<BlogImage> repository) : base(repository)
        {
        }

        public Task<List<BlogImage>> GetAllBlogImagesByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogImage> GetBlogImageByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogImage>> GetSomeBlogImagesByIncludeAsync(Expression<Func<BlogImage, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
