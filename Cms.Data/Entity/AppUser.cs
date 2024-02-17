using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class AppUser : IdentityUser
	{
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        [DisplayName("İsim")]
		public string FullName { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        [DisplayName("Şehir")]
		public string City { get; set; }

	}
}
