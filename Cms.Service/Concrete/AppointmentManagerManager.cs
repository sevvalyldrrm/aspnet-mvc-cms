using Cms.Data.Abstract;
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
        public class AppointmentManagerManager : GenericManager<Cms.Data.Entity.AppointmentManager>, IAppointmentManagerService
        {
            private readonly IAppointmentManagerRepository _repository;

            public AppointmentManagerManager(IAppointmentManagerRepository repository) : base(repository)
            {
                _repository = repository;
            }

        public async Task<List<Data.Entity.AppointmentManager>> GetAllAppointmentManagersByIncludeAsync()
        {
            return await _repository.GetAllAppointmentManagersByIncludeAsync();
        }

        public async Task<Data.Entity.AppointmentManager> GetAppointmentManagerByIncludeAsync(int id)
        {
            return await _repository.GetAppointmentManagerByIncludeAsync(id);
        }

        public async Task<List<Data.Entity.AppointmentManager>> GetSomeAppointmentManagersByIncludeAsync(Expression<Func<Data.Entity.AppointmentManager, bool>> expression)
        {
            return await _repository.GetSomeAppointmentManagersByIncludeAsync(expression);
        }
    }
    }


