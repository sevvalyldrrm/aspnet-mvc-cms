using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity.BaseEntites
{
	public abstract class BaseAuditEntity : BaseEntity, IAuditEntity
	{
		public DateTime CreatedAt {  get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;
		public DateTime? DeletedAt { get; set; }
	}
}
