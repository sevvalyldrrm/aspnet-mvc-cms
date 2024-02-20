using Cms.Data.Abstract;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
	public interface IAppointmentService: IGenericService<Appointment>
	{
        Task<Appointment> GetAppointmentByIncludeAsync(int id);

        Task<List<Appointment>> GetAllAppointmentsByIncludeAsync();

        Task<List<Appointment>> GetSomeAppointmentsByIncludeAsync(Expression<Func<Appointment, bool>> expression);
    }
}
