using Cms.Data.Abstract;
using Cms.Data.Entity;
using Cms.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
	public class AppointmentManager : GenericManager<Appointment>, IAppointmentService
    {
        private readonly IAppointmentRepository _repository;
		public AppointmentManager(IAppointmentRepository repository) : base(repository)
		{
            _repository = repository;
		}

		public async Task<List<Appointment>> GetAllAppointmentsByIncludeAsync()
        {
           return await _repository.GetAllAppointmentsByIncludeAsync();
        }

        public async Task<Appointment> GetAppointmentByIncludeAsync(int id)
        {
            return await _repository.GetAppointmentByIncludeAsync(id);
        }

        public async Task<List<Appointment>> GetSomeAppointmentsByIncludeAsync(Expression<Func<Appointment, bool>> expression)
        {
            return await _repository.GetSomeAppointmentsByIncludeAsync(expression);
		}
    }
}
