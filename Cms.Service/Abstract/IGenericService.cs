﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Abstract
{
	public interface IGenericService<T> where T : class
	{
		Task<T> FindAsync(int id);

		Task<T> GetAsync(Expression<Func<T, bool>> expression);

		Task<List<T>> GetAllAsync();

		Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);

		Task AddAsync(T entity);

		Task DeleteAsync(T entity);

		Task UpdateAsync(T entity);

		Task<int> SaveAsync();
	}
}
