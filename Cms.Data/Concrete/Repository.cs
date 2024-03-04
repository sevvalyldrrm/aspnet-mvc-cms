using Cms.Data.Entity.BaseEntites;
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
	public class Repository<TEntity, TContext> : IRepository<TEntity>  //using'ler kaldırılmalı.
		where TEntity : class
		where TContext : AppDbContext, new()
	{
		private readonly DbContext _dbContext;

		public Repository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task AddAsync(TEntity entity)
		{

			await _dbContext.Set<TEntity>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(TEntity entity)
		{
			_dbContext.Set<TEntity>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<TEntity> FindAsync(int id)
		{

			return await _dbContext.Set<TEntity>().FindAsync(id);
		}

		public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
		{

			return filter == null ? await _dbContext.Set<TEntity>().ToListAsync() : await _dbContext.Set<TEntity>().Where(filter).ToListAsync();
		}

		public async Task<List<TEntity>> GetAllAsync()
		{

			return await _dbContext.Set<TEntity>().ToListAsync();
		}

		public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
		{

			return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(expression);
		}

		public async Task<int> SaveAsync()
		{
			return await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateAsync(TEntity entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();

		}
	}

}
