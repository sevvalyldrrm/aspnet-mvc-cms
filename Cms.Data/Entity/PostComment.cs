using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cms.Data.Entity
{
	public class PostComment : IAuditEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("User")]
		public int UserId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("Yorum")]
		public string Comment { get; set; }
		public bool IsActive { get; set; }

		// IAuditEntity implementation
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }

		// Navigation properties
		//public Post Post { get; set; }
		//public User User { get; set; }
	}
}
