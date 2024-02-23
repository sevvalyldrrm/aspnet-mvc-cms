using Cms.Data.Abstract;
using Cms.Data.DataContext;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Concrete
{
    public class DoctorPatientRepository : Repository<DoctorPatient, AppDbContext>, IDoctorPatientRepository
    {
        private readonly AppDbContext _context;

        public DoctorPatientRepository(AppDbContext context)
        {
            _context = context;
        }
    }
    ]
