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
	public class Page : IAuditEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("Başlık")]
		public string Title { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("İçerik")]
		public string Content { get; set; }
		public bool IsActive { get; set; }

		// IAuditEntity implementation
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }
	}




}
