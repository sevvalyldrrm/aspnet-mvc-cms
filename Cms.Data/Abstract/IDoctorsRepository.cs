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
	public interface IDoctorRepository : IRepository<Doctor>
	{
		Task<Doctor> GetDoctorByIncludeAsync(int id);

		Task<List<Doctor>> GetAllDoctorsByIncludeAsync();

		Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression);
	}
}
