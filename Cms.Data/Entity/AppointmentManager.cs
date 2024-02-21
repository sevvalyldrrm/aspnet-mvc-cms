using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
    public class AppointmentManager
    {
        public int AppointmentManagerId { get; set; }

        [ForeignKey(nameof(Doctor.Id))]
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey(nameof(Patient.Id))]
        public string PatientId { get; set; }
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
