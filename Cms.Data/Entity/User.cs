using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[EmailAddress]
		[StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("Email adresi")]
		public string Email { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[StringLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("Şifre")]
		public string Password { get; set; }

		[StringLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("İsim")]
		public string Name { get; set; }

		[StringLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		[DisplayName("Şehir")]
		public string City { get; set; }

		[DisplayName("Telefon")]
		[StringLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
		public string Phone { get; set; }
	}
}
