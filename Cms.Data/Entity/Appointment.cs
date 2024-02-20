using Cms.Data.Entity;
using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Appointment : BaseEntity
    {
		[ForeignKey("CategoryId")]
		public int CategoryId { get; set; }

		public Category Category { get; set; }

		[ForeignKey("DoctorId")]
		public int DoctorId { get; set; }

		public Doctor Doctor { get; set; }

		public string Email { get; set;}

		public string FullName { get; set;}

		public string Phone {  get; set;}

		public string Message {  get; set;}
	}
}
