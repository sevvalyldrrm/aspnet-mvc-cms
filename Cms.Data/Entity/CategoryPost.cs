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
	public class CategoryPost : BaseEntity
	{

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Category")]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Post")]
		public int PostId { get; set; }

		
	}
}
