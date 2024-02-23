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
    public class SurgeryManager : ISurgeryService
    {
        public Task AddAsync(Surgery entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Surgery entity)
        {
            throw new NotImplementedException();
        }

        public Task<Surgery> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Surgery>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Surgery>> GetAllAsync(Expression<Func<Surgery, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Surgery>> GetAllSurgeriesByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Surgery> GetAsync(Expression<Func<Surgery, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Surgery>> GetSomeSurgeriesByIncludeAsync(Expression<Func<Surgery, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Surgery> GetSurgeryByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Surgery entity)
        {
            throw new NotImplementedException();
        }
    }
}
