﻿using Cms.Data.Entity;
using Cms.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Abstract
{
	public interface ICategoryRepository : IRepository<Category>
	{
		Task<Category> GetCategoryByIncludeAsync(int id);

		Task<List<Category>> GetAllCategoryByIncludeAsync();

		Task<List<Category>> GetSomeCategoryByIncludeAsync(Expression<Func<Category, bool>> expression);
	}
}