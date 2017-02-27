using System;
using System.Collections.Generic;

namespace Project.Domain.Contracts.Services.ElasticSearch
{
    public interface IBaseDomainElasticSearchService<TEntity> 
        where TEntity : class
    {
        void Insert(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
