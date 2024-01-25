using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
	public class Category
	{
		public int Id { get; set; }	
		public string Name { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }

	}
}
