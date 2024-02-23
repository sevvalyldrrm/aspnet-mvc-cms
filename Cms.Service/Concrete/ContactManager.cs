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
    public class ContactManager : GenericManager<Contact>, IContactService
    {
       private readonly IContactRepository _repository;
        public ContactManager(IContactRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
