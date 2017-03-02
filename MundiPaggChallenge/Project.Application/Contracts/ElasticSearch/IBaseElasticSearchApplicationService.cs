using System;
using System.Collections.Generic;

namespace Project.Application.Contracts.ElasticSearch
{
    public interface IBaseElasticSearchApplicationService<TEntity> where TEntity : class
    {
        void Insert(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
