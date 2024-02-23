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
    public class EducationManager : GenericManager<Education>,IEducationService
    {
        private readonly IEducationRepository _repository;

        public EducationManager(IEducationRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<Education>> GetAllEducationsByIncludeAsync()
        {
            return await _repository.GetAllEducationsByIncludeAsync();
        }

        public async Task<Education> GetEducationByIncludeAsync(int id)
        {
            return await _repository.GetEducationByIncludeAsync(id);
        }

        public async Task<List<Education>> GetSomeEducationsByIncludeAsync(Expression<Func<Education, bool>> expression)
        {
            return await _repository.GetSomeEducationsByIncludeAsync(expression);
        }
    }
}
