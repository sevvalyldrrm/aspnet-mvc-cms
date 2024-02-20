using Cms.Data.Abstract;
using Cms.Data.Entity;
using Cms.Service.Abstract;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
	public class PatientManager : IPatientService
	{
		private readonly IPatientRepository _repository;

		public PatientManager(IPatientRepository repository)
		{
			_repository = repository;
		}

		public async Task AddAsync(Patient entity)
		{
			await _repository.AddAsync(entity);
		}

		public async Task DeleteAsync(Patient entity)
		{
			await _repository.DeleteAsync(entity);
		}

		public async Task<Patient> FindAsync(int id)
		{
			return await _repository.FindAsync(id);
		}

		public async Task<List<Patient>> GetAllAsync()
		{
			return await _repository.GetAllAsync();
		}

		public async Task<List<Patient>> GetAllAsync(Expression<Func<Patient, bool>> expression)
		{
			return await _repository.GetAllAsync(expression);
		}

        public async Task<List<Patient>> GetAllPatientsByIncludeAsync()
        {
            return await _repository.GetAllPatientsByIncludeAsync();
        }

        public async Task<Patient> GetAsync(Expression<Func<Patient, bool>> expression)
		{
			return await _repository.GetAsync(expression);
		}

        public async Task<Patient> GetPatientByIncludeAsync(string id)
        {
            return await _repository.GetPatientByIncludeAsync(id);
        }

        public async Task<List<Patient>> GetSomePatientsByIncludeAsync(Expression<Func<Patient, bool>> expression)
        {
            return await _repository.GetSomePatientsByIncludeAsync(expression);
        }

        public async Task<int> SaveAsync()
		{
			return await _repository.SaveAsync();
		}

		public async Task UpdateAsync(Patient entity)
		{
			await _repository.UpdateAsync(entity);
		}
	}
}
