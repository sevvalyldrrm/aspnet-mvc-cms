using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Domain.Entities.BaseEntities;


namespace Hospital.Domain.Entities
{
	public class DepartmentBlog : BaseEntitiy
	{
		//Blog Single sayfasındaki "Categories" kısmı için yazıldı. Biz burada blog post'larının hangi departman tarafından yazıldığını belirtmek istiyoruz.

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Department")]
		public int DepartmentId { get; set; }

		public Department Department { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[ForeignKey("Blog")]
		public int BlogId { get; set; }

		public Blog Blog {  get; set; }

		
	}
}
