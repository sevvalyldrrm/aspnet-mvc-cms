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
    public class DepartmentDetailRepository : Repository<DepartmentDetail, AppDbContext>, IDepartmentDetailRepository
    {
        private readonly AppDbContext _context;

        public DepartmentDetailRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DepartmentDetail>> GetAllDepartmentDetailsByIncludeAsync()
        {
            return await _context.DepartmentDetails.Include(x => x.DepartmentFeatures).Include(x => x.Department).AsNoTracking().ToListAsync();
        }

        public async Task<DepartmentDetail> GetDepartmentDetailByIncludeAsync(int id)
        {
            return await _context.DepartmentDetails.Include(x => x.DepartmentFeatures).Include(x => x.Department).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<DepartmentDetail>> GetSomeDepartmentDetailsByIncludeAsync(Expression<Func<DepartmentDetail, bool>> expression)
        {
            return await _context.DepartmentDetails.Include(x => x.DepartmentFeatures).Include(x => x.Department).AsNoTracking().Where(expression).ToListAsync();
        }
    }
}
