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
	public interface IPatientService : IGenericService<Patient>
	{
        Task<Patient> GetPatientByIncludeAsync(string id);

        Task<List<Patient>> GetAllPatientsByIncludeAsync();

        Task<List<Patient>> GetSomePatientsByIncludeAsync(Expression<Func<Patient, bool>> expression);
    }
}
