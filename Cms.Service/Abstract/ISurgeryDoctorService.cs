using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
    public  interface ISurgeryDoctorService : IGenericService<SurgeryDoctor>
    {
        Task<SurgeryDoctor> GetSurgeryDoctorByIncludeAsync(int id);

        Task<List<SurgeryDoctor>> GetAllSurgeryDoctorsByIncludeAsync();

        Task<List<SurgeryDoctor>> GetSomeSurgeryDoctorsByIncludeAsync(Expression<Func<SurgeryDoctor, bool>> expression);
    }
}
