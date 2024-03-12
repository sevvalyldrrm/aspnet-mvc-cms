
using Hospital.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Entities
{
    public class AppRole : BaseEntitiy
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }

		public virtual ICollection<AppUserRole> UserRoles { get; set; }
	}
}
