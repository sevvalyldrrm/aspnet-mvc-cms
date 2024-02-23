using Cms.Data.Abstract;
using Cms.Data.DataContext;
using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Concrete
{
    public class BlogImageRepository : Repository<BlogImage, AppDbContext>, IBlogImageRepository
    {
        private readonly AppDbContext _context;

        public BlogImageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BlogImage>> GetAllBlogImagesByIncludeAsync()
        {
            return await _context.BlogImages.Include(p => p.Blog).ToListAsync();

        }

        public async Task<BlogImage> GetBlogImageByIncludeAsync(int id)
        {
            return await _context.BlogImages.Include(p => p.Blog).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<BlogImage>> GetSomeBlogImagesByIncludeAsync(Expression<Func<BlogImage, bool>> expression)
        {
            return await _context.BlogImages.Where(expression).Include(p => p.Blog).ToListAsync();
        }
    }
}
