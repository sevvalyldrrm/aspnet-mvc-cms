using Cms.Data.Entity;
using Cms.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
	public interface IDoctorRepository : IUserRepository<Doctor>
	{
		Task<Doctor> GetDoctorByIncludeAsync(string id);

		Task<List<Doctor>> GetAllDoctorsByIncludeAsync();

		Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression);

        Task<IEnumerable<WorkingHour>> GetWorkingHoursByDoctorIdAsync(string doctorId);
        Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAsync(string doctorId);
    }
}
