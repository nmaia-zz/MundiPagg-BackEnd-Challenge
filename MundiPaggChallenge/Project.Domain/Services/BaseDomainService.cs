using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using System.Linq;

namespace Project.Domain.Services
{
    public class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        private readonly IBaseRepository<TEntity, TKey> repository;

        public BaseDomainService(IBaseRepository<TEntity, TKey> repository)
        {
            this.repository = repository;
        }

        public void Insert(TEntity obj)
        {
            repository.BeginTransaction();
            repository.Insert(obj);
            repository.Commit();
        }

        public void Update(TEntity obj)
        {
            repository.BeginTransaction();
            repository.Update(obj);
            repository.Commit();
        }

        public void Delete(TEntity obj)
        {
            repository.BeginTransaction();
            repository.Delete(obj);
            repository.Commit();
        }

        public IQueryable<TEntity> FindAll()
        {
            return repository.FindAll();
        }

        public TEntity FindById(TKey key)
        {
            return repository.FindById(key);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
