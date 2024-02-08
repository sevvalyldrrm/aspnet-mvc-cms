using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Doctor : AppUser
	{
		public string Speacialty { get; set; }

		public ICollection<Patient> Patients { get; set; }

		public int DepartmanId { get; set; }
	}
}
