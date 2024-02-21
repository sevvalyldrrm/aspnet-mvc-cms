using Cms.Data.Abstract;
using Cms.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
    public class AvailabilityService : IAvailabilityService
    {
        private readonly IDoctorRepository _doctorRepository;

        public AvailabilityService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<bool> IsDoctorAvailableAsync(string doctorId, DateTime appointmentDate, TimeSpan appointmentTime)
        {
            var workingHours = await _doctorRepository.GetWorkingHoursByDoctorIdAsync(doctorId);
            var appointments = await _doctorRepository.GetAppointmentsByDoctorIdAsync(doctorId);

            var workingDay = workingHours.FirstOrDefault(wh => wh.DayOfWeek == appointmentDate.DayOfWeek);
            if (workingDay == null)
            {
                return false;
            }

            if (appointmentTime < workingDay.StartTime || appointmentTime > workingDay.EndTime)
            {
                return false;
            }

            foreach (var appointment in appointments)
            {
                if (appointment.AppointmentDate.Date == appointmentDate.Date &&
                    appointment.AppointmentDate.TimeOfDay <= appointmentTime &&
                    appointmentTime < appointment.AppointmentDate.TimeOfDay.Add(TimeSpan.FromMinutes(30))) 
                {
                    return false;
                }
            }

            return true;
        }
    }

}
