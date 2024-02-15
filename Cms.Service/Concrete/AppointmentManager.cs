using Cms.Data.Abstract;
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
	public class AppointmentManager : IAppoitmentService
	{
		private readonly IAppointmentRepository _repository;

        public AppointmentManager(IAppointmentRepository repository)
        {
            _repository = repository;
        }

		public async Task AddAsync(Appointment entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Appointment entity)
		{
			await _repository.DeleteAsync(entity);	
		}

		public async Task<Appointment> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Appointment>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Appointment>> GetAllAsync(Expression<Func<Appointment, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

		public async Task<Appointment> GetAsync(Expression<Func<Appointment, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

		public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Appointment entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
