﻿using Cms.Data.Abstract;
using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
	public interface IDepartmentService : IGenericService<Department>
	{
        Task<Department> GetDepartmentByIncludeAsync(int id);

        Task<List<Department>> GetAllDepartmentByIncludeAsync();

        Task<List<Department>> GetSomeDepartmentByIncludeAsync(Expression<Func<Department, bool>> expression);
    }
}
