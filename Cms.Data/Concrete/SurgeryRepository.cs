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
    public class SurgeryRepository : Repository<Surgery, AppDbContext>, ISurgeryRepository
    {
        private readonly AppDbContext _context;

        public SurgeryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Surgery>> GetAllSurgeriesByIncludeAsync()
        {
            return await _context.Surgeries.Include(x => x.Patient).Include(x => x.Department).Include(x => x.SurgeryDoctors).ThenInclude(x => x.Doctor).AsNoTracking().ToListAsync();
        }

        public async Task<Surgery> GetSurgeryByIncludeAsync(int id)
        {
            return await _context.Surgeries.Include(x => x.Patient).Include(x => x.Department).Include(x => x.SurgeryDoctors).ThenInclude(x => x.Doctor).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Surgery>> GetSomeSurgeriesByIncludeAsync(Expression<Func<Surgery, bool>> expression)
        {
            return await _context.Surgeries.Include(x => x.Patient).Include(x => x.Department).Include(x => x.SurgeryDoctors).ThenInclude(x => x.Doctor).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
