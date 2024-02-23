using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
    public interface IEducationService : IGenericService<Education>
    {
        Task<Education> GetEducationByIncludeAsync(int id);

        Task<List<Education>> GetAllEducationsByIncludeAsync();

        Task<List<Education>> GetSomeEducationsByIncludeAsync(Expression<Func<Education, bool>> expression);
    }
}
