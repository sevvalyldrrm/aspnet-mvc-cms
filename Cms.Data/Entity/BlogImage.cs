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
	public class BlogImage : BaseEntity
	{

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Blog")]
		public int BlogId { get; set; }

		public Blog Blog { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        [DisplayName("Dosya yolu")]
		public string ImagePath { get; set; }//burasi gerekli mi?appuser foto

	}
}
