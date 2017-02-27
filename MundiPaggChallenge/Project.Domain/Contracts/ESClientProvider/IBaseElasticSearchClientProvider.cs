using System;
using System.Collections.Generic;

namespace Project.Domain.Contracts.ESClientProvider
{
    public interface IBaseElasticSearchClientProvider<TEntity> 
        where TEntity : class
    {
        void Insert(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
