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
	public class Setting : BaseEntity
	{

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("User")]

		public int UserId { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("İsim")]
		public string Name { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[StringLength(400, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("Değer")]
		public string Value { get; set; }

		
	}
}
