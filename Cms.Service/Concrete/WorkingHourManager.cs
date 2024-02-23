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
    public class WorkingHourManager:GenericManager<WorkingHour>,IWorkingHourService
    {
        private readonly IWorkingHourRepository _repository;
        public WorkingHourManager(IWorkingHourRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<WorkingHour>> GetAllWorkingHoursByIncludeAsync()
        {
            return await _repository.GetAllWorkingHoursByIncludeAsync();
        }

        public async Task<List<WorkingHour>> GetSomeWorkingHoursByIncludeAsync(Expression<Func<WorkingHour, bool>> expression)
        {
            return await _repository.GetSomeWorkingHoursByIncludeAsync(expression);
        }

        public async Task<WorkingHour> GetWorkingHourByIncludeAsync(int id)
        {
            return await _repository.GetWorkingHourByIncludeAsync(id);
        }
    }
}
