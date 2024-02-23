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
    public class IntroductionRepository : Repository<Introduction, AppDbContext>, IIntroductionRepository
    {
        private readonly AppDbContext _context;

        public IntroductionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Introduction>> GetAllIntroductionsByIncludeAsync()
        {
            return await _context.Introductions.Include(x => x.Doctor).Include(x => x.ExpertisesAreas).Include(x => x.Educations).Include(x => x.WorkingHour).AsNoTracking().ToListAsync();
        }

        public async Task<Introduction> GetIntroductionByIncludeAsync(int id)
        {
            return await _context.Introductions.Include(x => x.Doctor).Include(x => x.ExpertisesAreas).Include(x => x.Educations).Include(x => x.WorkingHour).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Introduction>> GetSomeIntroductionsByIncludeAsync(Expression<Func<Introduction, bool>> expression)
        {
            return await _context.Introductions.Include(x => x.Doctor).Include(x => x.ExpertisesAreas).Include(x => x.Educations).Include(x => x.WorkingHour).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
