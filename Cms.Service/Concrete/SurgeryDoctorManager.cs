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
    public class SurgeryDoctorManager : GenericManager<SurgeryDoctor>,ISurgeryDoctorService
    {
       private readonly ISurgeryDoctorRepository _repository;

        public SurgeryDoctorManager(ISurgeryDoctorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<SurgeryDoctor>> GetAllSurgeryDoctorsByIncludeAsync()
        {
            return await _repository.GetAllSurgeryDoctorsByIncludeAsync();
        }

        public async Task<List<SurgeryDoctor>> GetSomeSurgeryDoctorsByIncludeAsync(Expression<Func<SurgeryDoctor, bool>> expression)
        {
            return await _repository.GetSomeSurgeryDoctorsByIncludeAsync(expression);
        }

        public async Task<SurgeryDoctor> GetSurgeryDoctorByIncludeAsync(int id)
        {
            return await _repository.GetSurgeryDoctorByIncludeAsync(id);
        }
    }
}
