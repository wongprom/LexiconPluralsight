﻿using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageAp.Entities;

namespace WiredBrainCoffee.StorageAp.Repositories
{
    public delegate void ItemAdded(object item);
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly ItemAdded? _itemAddedCallback;
        private readonly DbSet<T> _dbSet;


        public SqlRepository(DbContext dbContext, ItemAdded? itemAddedCallback = null)
        {
            _dbContext = dbContext;
            _itemAddedCallback = itemAddedCallback;
            _dbSet = _dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
            _itemAddedCallback?.Invoke(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
