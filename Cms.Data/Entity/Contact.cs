using Cms.Data.Entity.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Contact : BaseAuditEntity
	{
		//Contact Us Sayfası
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
	}
}
