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
    public class SurgeryDoctorRepository : Repository<SurgeryDoctor, AppDbContext>, ISurgeryDoctorRepository
    {
        private readonly AppDbContext _context;

        public SurgeryDoctorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SurgeryDoctor>> GetAllSurgeryDoctorsByIncludeAsync()
        {
            return await _context.SurgeryDoctors.Include(x => x.Doctor).Include(x => x.Surgery).AsNoTracking().ToListAsync();
        }

        public async Task<SurgeryDoctor> GetSurgeryDoctorByIncludeAsync(int id)
        {
            return await _context.SurgeryDoctors.Include(x => x.Doctor).Include(x => x.Surgery).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<SurgeryDoctor>> GetSomeSurgeryDoctorsByIncludeAsync(Expression<Func<SurgeryDoctor, bool>> expression)
        {
            return await _context.SurgeryDoctors.Include(x => x.Doctor).Include(x => x.Surgery).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
