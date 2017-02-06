using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using System.Linq;

namespace Project.Application.Services
{
    public class BaseApplicationService<TEntity, TKey> : IBaseApplicationService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        private readonly IBaseDomainService<TEntity, TKey> domain;

        public BaseApplicationService(IBaseDomainService<TEntity, TKey> domain)
        {
            this.domain = domain;
        }

        public void Insert(TEntity obj)
        {
            domain.Insert(obj);
        }

        public void Update(TEntity obj)
        {
            domain.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            domain.Delete(obj);
        }

        public IQueryable<TEntity> FindAll()
        {
            return domain.FindAll();
        }

        public TEntity FindById(TKey key)
        {
            return domain.FindById(key);
        } 

        public void Dispose()
        {
            domain.Dispose();
        }
    }
}
