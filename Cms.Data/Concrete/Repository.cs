﻿using Cms.Data.Entity.BaseEntites;
using Cms.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.DataContext;

namespace Cms.Data.Concrete
{
	public class Repository<TEntity, TContext> : IRepository<TEntity>
		where TEntity : class
		where TContext : AppDbContext, new()
	{
		public async Task AddAsync(TEntity entity)
		{
			using (var context = new TContext())
			{
				await context.Set<TEntity>().AddAsync(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task DeleteAsync(TEntity entity)
		{
			using (var context = new TContext())
			{
				context.Set<TEntity>().Remove(entity);
				await context.SaveChangesAsync();
			}
		}

		public async Task<TEntity> FindAsync(int id)
		{
			using (var context = new TContext())
			{
				return await context.Set<TEntity>().FindAsync(id);
			}
		}

		public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return  filter == null ? await context.Set<TEntity>().ToListAsync() : await context.Set<TEntity>().Where(filter).ToListAsync();
			}
		}

		public async Task<List<TEntity>> GetAllAsync()
		{
			using (var context = new TContext())
			{
				return await context.Set<TEntity>().ToListAsync();
			}
		}

		public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
		{
			using (var context = new TContext())
			{
				return await context.Set<TEntity>().FirstOrDefaultAsync(expression);
			}
		}

		public async Task<int> SaveAsync()
		{
			using (var context = new TContext())
			{
				return await context.SaveChangesAsync();
			}
		}

		public async Task UpdateAsync(TEntity entity)
		{
			using (var context = new TContext())
			{
			    context.Entry(entity).State = EntityState.Modified;
				await context.SaveChangesAsync();
			}
		}
	}

}
