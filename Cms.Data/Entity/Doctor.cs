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

		public int CategoryId { get; set; }

		public Category Category { get; set; }

		public AppRole Role { get; set; }
	}
}
