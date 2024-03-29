﻿using Cms.Data.Abstract;
using Cms.Data.DataContext;
using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Concrete
{
	public class PatientRepository : UserRepository<Patient, AppDbContext>, IPatientRepository
	{
		private readonly AppDbContext _context;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Patient>> GetAllPatientsByIncludeAsync()
		{
			return await _context.Patients.Include(p => p.DoctorPatients).ThenInclude(dp => dp.Doctor).Include(d => d.Role).ToListAsync();
		}

		public async Task<Patient> GetPatientByIncludeAsync(string id)
		{
			return await _context.Patients.Include(p => p.DoctorPatients).ThenInclude(dp => dp.Doctor).Include(d => d.Role).FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<List<Patient>> GetSomePatientsByIncludeAsync(Expression<Func<Patient, bool>> expression)
		{
			return await _context.Patients.Where(expression).Include(d => d.Role).Include(p => p.DoctorPatients).ThenInclude(dp => dp.Doctor).ToListAsync();
		}
        public async Task<List<Patient>> GetAllAppointmentsofPatientByIncludeAsync()
        {
            return await _context.Patients.Include(d => d.Appointments).Include(p => p.DoctorPatients).ThenInclude(dp => dp.Doctor).ToListAsync();
        }

        public async Task<List<Patient>> GetAllSurgeriesofPatientByIncludeAsync()
        {
            return await _context.Patients.Include(p => p.Surgeries).Include(p => p.DoctorPatients).ThenInclude(dp => dp.Doctor).ToListAsync();
        }
        

    }
}
