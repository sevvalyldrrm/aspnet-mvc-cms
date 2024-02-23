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
    public class EducationRepository : Repository<Education, AppDbContext>, IEducationRepository
    {
        private readonly AppDbContext _context;

        public EducationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Education>> GetAllEducationsByIncludeAsync()
        {
            return await _context.Educations.Include(x => x.Doctor).AsNoTracking().ToListAsync();
        }

        public async Task<Education> GetEducationByIncludeAsync(int id)
        {
            return await _context.Educations.Include(x => x.Doctor).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Education>> GetSomeEducationsByIncludeAsync(Expression<Func<Education, bool>> expression)
        {
            return await _context.Educations.Include(x => x.Doctor).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
