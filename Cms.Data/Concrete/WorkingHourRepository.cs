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
    public class WorkingHourRepository : Repository<WorkingHour, AppDbContext>, IWorkingHourRepository
    {
        private readonly AppDbContext _context;

        public WorkingHourRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkingHour>> GetAllWorkingHoursByIncludeAsync()
        {
            return await _context.WorkingHours.Include(x => x.Doctor).AsNoTracking().ToListAsync();
        }

        public async Task<WorkingHour> GetWorkingHourByIncludeAsync(int id)
        {
            return await _context.WorkingHours.Include(x => x.Doctor).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<WorkingHour>> GetSomeWorkingHoursByIncludeAsync(Expression<Func<WorkingHour, bool>> expression)
        {
            return await _context.WorkingHours.Include(x => x.Doctor).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
