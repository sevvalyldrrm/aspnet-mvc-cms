using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
    public interface  IAppointmentManagerRepository : IRepository<AppointmentManager>
    {
        Task<AppointmentManager> GetAppointmentManagerByIncludeAsync(int id);

        Task<List<AppointmentManager>> GetAllAppointmentManagersByIncludeAsync();

        Task<List<AppointmentManager>> GetSomeAppointmentManagersByIncludeAsync(Expression<Func<AppointmentManager, bool>> expression);
    }
}
