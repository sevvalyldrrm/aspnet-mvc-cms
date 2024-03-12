
using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
    public class AppointmentManager : BaseEntitiy
	{
        
        [ForeignKey(nameof(Doctor.Id))]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [ForeignKey(nameof(Patient.Id))]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public AppointmentStatus Status { get; set; }

        public ICollection<WorkingHour> WorkingHours { get; set; }
    }
}

public enum AppointmentStatus
{
    Pending,
    Confirmed,
    Completed,
    Cancelled
}
