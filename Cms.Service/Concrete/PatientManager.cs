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
	public class PatientManager : UserManager<Patient>,IPatientService
	{
		private readonly IPatientRepository _repository;

		public PatientManager(IPatientRepository repository) : base(repository)
        {
			_repository = repository;
		}

        public async Task<List<Patient>> GetAllPatientsByIncludeAsync()
        {
            return await _repository.GetAllPatientsByIncludeAsync();
        }

        public async Task<Patient> GetPatientByIncludeAsync(string id)
        {
            return await _repository.GetPatientByIncludeAsync(id);
        }

        public async Task<List<Patient>> GetSomePatientsByIncludeAsync(Expression<Func<Patient, bool>> expression)
        {
            return await _repository.GetSomePatientsByIncludeAsync(expression);
        }
    }
}
