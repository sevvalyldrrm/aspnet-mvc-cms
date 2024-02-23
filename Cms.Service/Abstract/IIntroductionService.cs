using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
    public interface IIntroductionService : IGenericService<Introduction>
    {
        Task<Introduction> GetIntroductionByIncludeAsync(int id);

        Task<List<Introduction>> GetAllIntroductionsByIncludeAsync();

        Task<List<Introduction>> GetSomeIntroductionsByIncludeAsync(Expression<Func<Introduction, bool>> expression);
    }
}
