using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Patient : AppUser
	{
		public string Diagnosis {  get; set; }

		public bool IsDischarged { get; set; }

        [ForeignKey("AppRole")]
        public string RoleId {  get; set; }
		public AppRole Role { get; set; }

        public ICollection<DoctorPatient> DoctorPatients { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }

    }
}
