﻿using Cms.Data.Abstract;
using Cms.Data.DataContext;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Concrete
{
    public class ContactRepository : Repository<Contact, AppDbContext>, IContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
