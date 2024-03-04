﻿using Cms.Data.Abstract;
using Cms.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepository<T> _repository; //list version eklenebilir.

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _repository.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.GetAllAsync(expression);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.GetAsync(expression);
        }

        public async Task<int> SaveAsync()
        {
            return await _repository.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
