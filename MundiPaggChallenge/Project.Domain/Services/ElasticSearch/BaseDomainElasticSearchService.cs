using System;
using System.Collections.Generic;
using Project.Domain.Contracts.Services.ElasticSearch;
using Project.Domain.Contracts.ESClientProvider;

namespace Project.Domain.Services.ElasticSearch
{
    public class BaseDomainElasticSearchService<TEntity>
        : IBaseDomainElasticSearchService<TEntity>
        where TEntity : class
    {
        private readonly IBaseElasticSearchClientProvider<TEntity> _esClient;

        public BaseDomainElasticSearchService(IBaseElasticSearchClientProvider<TEntity> esClient)
        {
            _esClient = esClient;
        }

        public void Insert(TEntity obj)
        {
            _esClient.Insert(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _esClient.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _esClient.GetById(id);
        }
    }
}
