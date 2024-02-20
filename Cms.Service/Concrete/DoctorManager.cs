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
	public class DoctorManager : IDoctorService
	{
		private readonly IDoctorRepository _repository;

		public DoctorManager(IDoctorRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Doctor entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Doctor entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Doctor> FindAsync(string id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Doctor>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Doctor>> GetAllAsync(Expression<Func<Doctor, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Doctor>> GetAllDoctorsByIncludeAsync()
        {
            return await _repository.GetAllDoctorsByIncludeAsync();
        }

        public async Task<Doctor> GetAsync(Expression<Func<Doctor, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Doctor> GetDoctorByIncludeAsync(string id)
        {
            return await _repository.GetDoctorByIncludeAsync(id);
        }

        public async Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression)
        {
            return await _repository.GetSomeDoctorsByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Doctor entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
