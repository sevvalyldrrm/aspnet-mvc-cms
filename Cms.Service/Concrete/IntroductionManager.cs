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
    public class IntroductionManager : IIntroductionService
    {
        public Task AddAsync(Introduction entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Introduction entity)
        {
            throw new NotImplementedException();
        }

        public Task<Introduction> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Introduction>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Introduction>> GetAllAsync(Expression<Func<Introduction, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Introduction>> GetAllIntroductionsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Introduction> GetAsync(Expression<Func<Introduction, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Introduction> GetIntroductionByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Introduction>> GetSomeIntroductionsByIncludeAsync(Expression<Func<Introduction, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Introduction entity)
        {
            throw new NotImplementedException();
        }
    }
}
