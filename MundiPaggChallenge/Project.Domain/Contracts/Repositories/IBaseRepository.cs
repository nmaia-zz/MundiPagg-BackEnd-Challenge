using System.Linq;

namespace Project.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IQueryable<TEntity> FindAll();
        TEntity FindById(TKey id);

        IQueryable<TEntity> FindByType(string type);
        IQueryable<TEntity> FindByAvailability(bool loaned);
        IQueryable<TEntity> FindByKeyWord(string keyword);

        void BeginTransaction();
        void Commit();
        void Rollback();

        void Dispose();
    }
}
