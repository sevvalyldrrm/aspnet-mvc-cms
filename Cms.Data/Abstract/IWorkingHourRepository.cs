using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
    public interface IWorkingHourRepository : IRepository<WorkingHour>
    {
        Task<WorkingHour> GetWorkingHourByIncludeAsync(int id);

        Task<List<WorkingHour>> GetAllWorkingHoursByIncludeAsync();

        Task<List<WorkingHour>> GetSomeWorkingHoursByIncludeAsync(Expression<Func<WorkingHour, bool>> expression);
    }
}
