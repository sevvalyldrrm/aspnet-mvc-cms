using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.Entity.BaseEntites;

namespace Cms.Data.Entity
{
	public class DepartmentPost : BaseEntity
	{
		
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Department")]
		public int DepartmentId { get; set; }

		public Department Department { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }

		public Post Post {  get; set; }

		
	}
}
