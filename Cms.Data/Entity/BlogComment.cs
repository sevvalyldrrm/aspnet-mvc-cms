using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Cms.Data.Entity.BaseEntites;

namespace Cms.Data.Entity
{
	public class BlogComment : BaseEntity
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
		public string AppUserId {  get; set; }

	}
}
