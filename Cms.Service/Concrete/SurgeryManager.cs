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
    public class SurgeryManager : GenericManager<Surgery>, ISurgeryService
    {
        private readonly ISurgeryRepository _repository;

        public SurgeryManager(ISurgeryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<Surgery>> GetAllSurgeriesByIncludeAsync()
        {
            return await _repository.GetAllSurgeriesByIncludeAsync();
        }

        public async Task<List<Surgery>> GetSomeSurgeriesByIncludeAsync(Expression<Func<Surgery, bool>> expression)
        {
            return await _repository.GetSomeSurgeriesByIncludeAsync(expression); ;
        }

        public async Task<Surgery> GetSurgeryByIncludeAsync(int id)
        {
            return await _repository.GetSurgeryByIncludeAsync(id);
        }
    }
}
