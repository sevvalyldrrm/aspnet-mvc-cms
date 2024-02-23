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
    public class SurgeryDoctorManager : ISurgeryDoctorService
    {
        public Task AddAsync(SurgeryDoctor entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SurgeryDoctor entity)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDoctor> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SurgeryDoctor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<SurgeryDoctor>> GetAllAsync(Expression<Func<SurgeryDoctor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<SurgeryDoctor>> GetAllSurgeryDoctorsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDoctor> GetAsync(Expression<Func<SurgeryDoctor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<SurgeryDoctor>> GetSomeSurgeryDoctorsByIncludeAsync(Expression<Func<SurgeryDoctor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<SurgeryDoctor> GetSurgeryDoctorByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SurgeryDoctor entity)
        {
            throw new NotImplementedException();
        }
    }
}
