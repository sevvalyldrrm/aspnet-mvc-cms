using Cms.Data.Abstract;
using Cms.Data.Concrete;
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
    public class DoctorManager : UserManager<Doctor>, IDoctorService
    {
        public DoctorManager(IUserRepository<Appointment> repository) : base(repository)
        {
           
        }

        public Task<List<Doctor>> GetAllDoctorsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAsync(string doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> GetDoctorByIncludeAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkingHour>> GetWorkingHoursByDoctorIdAsync(string doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
