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
	public interface ICategoryService : IGenericService<Category>
	{
        Task<Category> GetCategoryByIncludeAsync(int id);

        Task<List<Category>> GetAllCategoryByIncludeAsync();

        Task<List<Category>> GetSomeCategoryByIncludeAsync(Expression<Func<Category, bool>> expression);
    }
}
