using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
	public class Contact : BaseEntitiy
	{
		//Contact Us Sayfası
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
	}
}
