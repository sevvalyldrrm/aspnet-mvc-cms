using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class CategoryPost
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Category")]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }

		// Navigation properties
		//public Category Category { get; set; }
		//public Post Post { get; set; }
	}
}
