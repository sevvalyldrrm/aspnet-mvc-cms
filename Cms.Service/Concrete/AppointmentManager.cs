using Cms.Data.Abstract;
using Cms.Data.Entity;
using Cms.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
	public class AppointmentManager : GenericManager<Appointment>, IAppointmentService
    {
        public AppointmentManager(IRepository<Appointment> repository) : base(repository)
        {
        }

        public Task<List<Appointment>> GetAllAppointmentsByIncludeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> GetAppointmentByIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Appointment>> GetSomeAppointmentsByIncludeAsync(Expression<Func<Appointment, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
