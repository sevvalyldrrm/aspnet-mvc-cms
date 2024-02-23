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
    public class DoctorPatientManager : IDoctorPatientService
    {
        public Task AddAsync(DoctorPatient entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DoctorPatient entity)
        {
            throw new NotImplementedException();
        }

        public Task<DoctorPatient> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DoctorPatient>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<DoctorPatient>> GetAllAsync(Expression<Func<DoctorPatient, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<DoctorPatient> GetAsync(Expression<Func<DoctorPatient, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DoctorPatient entity)
        {
            throw new NotImplementedException();
        }
    }
}
