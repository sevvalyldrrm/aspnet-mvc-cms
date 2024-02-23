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
    public class ContactManager : IContactService
    {
        public Task AddAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync(Expression<Func<Contact, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetAsync(Expression<Func<Contact, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
