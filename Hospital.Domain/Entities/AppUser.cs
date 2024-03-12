using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Domain.Entities.BaseEntities;

namespace Hospital.Domain.Entities
{
	public class AppUser : BaseEntitiy
    {
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        [DisplayName("İsim")]
		public string? FullName { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
        [DisplayName("Şehir")]
		public string? City { get; set; }

        public bool IsActive { get; set; } = true;
        public string? ImagePath { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }

		public virtual ICollection<AppUserRole> UserRoles { get; set; }

	}
}
