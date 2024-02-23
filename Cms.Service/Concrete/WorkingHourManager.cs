using Cms.Data.Entity;
using Cms.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
    public interface WorkingHourManager:IGenericService<WorkingHour>
    {
        Task<WorkingHour> GetWorkingHourByIncludeAsync(int id);

        Task<List<WorkingHour>> GetAllWorkingHoursByIncludeAsync();

        Task<List<WorkingHour>> GetSomeWorkingHoursByIncludeAsync(Expression<Func<WorkingHour, bool>> expression);
    }
}
