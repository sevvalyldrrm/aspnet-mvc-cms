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
	public class Department : BaseEntity
	{

		[DisplayName("İsim")]
		[Required(ErrorMessage = "{0} boş geçilemez")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        public string Name { get; set; }
		[DisplayName("Açıklama")]
		[StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		public string Description { get; set; }
		public ICollection<DepartmentPost> DepartmentPosts { get; set; }

		public Doctor Doctor { get; set; }

    }
}
