using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Hospital.Domain.Entities.BaseEntities;

namespace Hospital.Domain.Entities
{
	public class BlogComment : BaseEntitiy
	{
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Blog")]
		public int BlogId { get; set; }

		public Blog Blog { get; set; }	

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("Yorum")]
		public string Comment { get; set; }

		public bool IsActive { get; set; }

		//[ForeignKey(nameof(Patient.Id))]
		//public string PatientId { get; set; }

		//public Patient Patient { get; set; }

		public AppUser AppUser { get; set; }

		[ForeignKey(nameof (AppUser.Id))]
		public int AppUserId {  get; set; }

	}
}
