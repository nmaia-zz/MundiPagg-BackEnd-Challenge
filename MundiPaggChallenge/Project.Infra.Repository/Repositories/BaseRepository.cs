using Project.Domain.Contracts.Repositories;
using Project.Infra.Repository.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace Project.Infra.Repository.Repositories
{
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>, IDisposable
        where TEntity : class
        where TKey : struct
    {
        protected readonly DataContext context;
        private DbContextTransaction transaction;

        public BaseRepository()
        {
            context = new DataContext();
        }

        public virtual void Insert(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public virtual IQueryable<TEntity> FindAll()
        {
            return context.Set<TEntity>().AsQueryable();
        }

        public virtual TEntity FindById(TKey id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
