using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
    public interface IAvailabilityService
    {
        Task<bool> IsDoctorAvailableAsync(string doctorId, DateTime appointmentDate, TimeSpan appointmentTime);
    }
}
