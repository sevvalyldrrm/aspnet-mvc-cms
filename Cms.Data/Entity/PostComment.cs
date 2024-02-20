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
	public class PostComment : BaseEntity
    {
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }

		public Post Post { get; set; }	

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("Yorum")]
		public string Comment { get; set; }

		public bool IsActive { get; set; }
		[ForeignKey(nameof(Patient.Id))]
		public string PatientId { get; set; }

		public Patient Patient { get; set; }

	}
}
