using System;
using System.Collections.Generic;

namespace Project.ElasticSearch.Contracts
{
    public interface IBaseElasticSearchClientProvider<TEntity> where TEntity : class
    {
        void Insert(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
