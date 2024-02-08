using Cms.Data.Entity;
using Cms.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
	public interface IAppUserRepository : IRepository<AppUser>
	{
		Task<AppUser> GetUserByIncludeAsync(int userId);
		Task<List<AppUser>> GetAllUserByIncludeAsync();
	}
}
