using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Patient : AppUser
	{
		public string Diagnosis {  get; set; }

		public bool IsDischarged { get; set; }

		public int DoctorId { get; set; }

	}
}
