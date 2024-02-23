using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
    public interface ISurgeryRepository : IRepository<Surgery>
    {
        Task<Surgery> GetSurgeryByIncludeAsync(int id);

        Task<List<Surgery>> GetAllSurgeriesByIncludeAsync();

        Task<List<Surgery>> GetSomeSurgeriesByIncludeAsync(Expression<Func<Surgery, bool>> expression);
    }
}
