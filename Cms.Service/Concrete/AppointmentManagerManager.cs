using Cms.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
    public class AppointmentManagerManager : IAppointmentManagerService
    {
        public Task AddAsync(Data.Entity.AppointmentManager entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Data.Entity.AppointmentManager entity)
        {
            throw new NotImplementedException();
        }

        public Task<Data.Entity.AppointmentManager> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Data.Entity.AppointmentManager>> GetAllAppointmentManagersByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Data.Entity.AppointmentManager>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Data.Entity.AppointmentManager>> GetAllAsync(Expression<Func<Data.Entity.AppointmentManager, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Data.Entity.AppointmentManager> GetAppointmentManagerByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Data.Entity.AppointmentManager> GetAsync(Expression<Func<Data.Entity.AppointmentManager, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Data.Entity.AppointmentManager>> GetSomeAppointmentManagersByIncludeAsync(Expression<Func<Data.Entity.AppointmentManager, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Data.Entity.AppointmentManager entity)
        {
            throw new NotImplementedException();
        }
    }
}
