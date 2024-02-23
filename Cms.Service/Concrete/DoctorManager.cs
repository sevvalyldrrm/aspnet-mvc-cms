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
        private readonly IDoctorRepository _repository;
        public DoctorManager(IDoctorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<Doctor>> GetAllDoctorsByIncludeAsync()
        {
            return await _repository.GetAllDoctorsByIncludeAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorIdAsync(string doctorId)
        {
            return await _repository.GetAppointmentsByDoctorIdAsync(doctorId);
        }

        public async Task<Doctor> GetDoctorByIncludeAsync(string id)
        {
            return await _repository.GetDoctorByIncludeAsync(id);
        }

        public async Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression)
        {
            return await _repository.GetSomeDoctorsByIncludeAsync(expression);
        }

        public async Task<IEnumerable<WorkingHour>> GetWorkingHoursByDoctorIdAsync(string doctorId)
        {
            return await _repository.GetWorkingHoursByDoctorIdAsync(doctorId);
        }
    }
}
