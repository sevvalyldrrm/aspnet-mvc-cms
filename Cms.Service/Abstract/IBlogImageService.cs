using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
    public interface IBlogImageService : IGenericService<BlogImage>
    {
        Task<BlogImage> GetBlogImageByIncludeAsync(int id);

        Task<List<BlogImage>> GetAllBlogImagesByIncludeAsync();

        Task<List<BlogImage>> GetSomeBlogImagesByIncludeAsync(Expression<Func<BlogImage, bool>> expression);
    }
}
