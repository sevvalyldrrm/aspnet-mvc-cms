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
	public interface IDoctorService : IUserService<Doctor>
	{
        Task<Doctor> GetDoctorByIncludeAsync(string id);

        Task<List<Doctor>> GetAllDoctorsByIncludeAsync();

        Task<List<Doctor>> GetSomeDoctorsByIncludeAsync(Expression<Func<Doctor, bool>> expression);
    }
}
