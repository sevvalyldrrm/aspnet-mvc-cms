﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity.BaseEntites
{
	public interface IEntity: IAuditEntity
    {
		public int Id { get; set; }
	}
}
