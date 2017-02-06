using System.Linq;

namespace Project.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IQueryable<TEntity> FindAll();
        TEntity FindById(TKey key);
        void Dispose();
    }
}
