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
    public class EducationManager : IEducationService
    {
        public Task AddAsync(Education entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Education entity)
        {
            throw new NotImplementedException();
        }

        public Task<Education> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetAllAsync(Expression<Func<Education, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetAllEducationsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetAsync(Expression<Func<Education, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetEducationByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetSomeEducationsByIncludeAsync(Expression<Func<Education, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Education entity)
        {
            throw new NotImplementedException();
        }
    }
}
