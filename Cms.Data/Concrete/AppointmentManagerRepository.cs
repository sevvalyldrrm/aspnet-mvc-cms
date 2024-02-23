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
    public class AppointmentManagerRepository : Repository<AppointmentManager, AppDbContext>, IAppointmentManagerRepository
    {

        private readonly AppDbContext _context;

        public AppointmentManagerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<AppointmentManager>> GetAllAppointmentManagersByIncludeAsync()
        {
            return await _context.AppointmentManagers.Include(a => a.Doctor).Include(a => a.Patient).Include(a => a.WorkingHours).ToListAsync();

        }

        public async Task<AppointmentManager> GetAppointmentManagerByIncludeAsync(int id)
        {
            return await _context.AppointmentManagers.Include(a => a.Doctor).Include(a => a.WorkingHours).Include(a => a.Patient).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<AppointmentManager>> GetSomeAppointmentManagersByIncludeAsync(Expression<Func<AppointmentManager, bool>> expression)
        {
            return await _context.AppointmentManagers.Where(expression).Include(a => a.Doctor).Include(a => a.WorkingHours).Include(a => a.Patient).ToListAsync();
        }

    }
}
