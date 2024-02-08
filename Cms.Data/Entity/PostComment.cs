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
    public class PostComment : BaseAuditEntity
	{

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("AppUser")]
		public int AppUserId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("Yorum")]
		public string Comment { get; set; }
		public bool IsActive { get; set; }

	}
}
