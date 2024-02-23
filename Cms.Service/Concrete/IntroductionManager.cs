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
    public class IntroductionManager : GenericManager<Introduction>,IIntroductionService
    {
       private readonly IIntroductionRepository _repository;

        public IntroductionManager(IIntroductionRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<Introduction>> GetAllIntroductionsByIncludeAsync()
        {
            return await _repository.GetAllIntroductionsByIncludeAsync();
        }

        public async Task<Introduction> GetIntroductionByIncludeAsync(int id)
        {
            return await _repository.GetIntroductionByIncludeAsync(id);
        }

        public async Task<List<Introduction>> GetSomeIntroductionsByIncludeAsync(Expression<Func<Introduction, bool>> expression)
        {
            return await _repository.GetSomeIntroductionsByIncludeAsync(expression);
        }
    }
}
