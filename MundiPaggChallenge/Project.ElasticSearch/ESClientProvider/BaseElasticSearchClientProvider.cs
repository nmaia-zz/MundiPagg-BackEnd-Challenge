using System;
using System.Collections.Generic;
using Project.Domain.Contracts.ESClientProvider;
using Nest;

namespace Project.ElasticSearch.ESClientProvider
{
    public class BaseElasticSearchClientProvider<TEntity> 
        : IBaseElasticSearchClientProvider<TEntity> 
        where TEntity : class
    {
        #region ' Properties '

        private Uri esNode;
        private ConnectionSettings esSettings;
        private readonly string def_index = "elasticsearch";
        private ElasticClient esClient;

        #endregion

        #region ' Constructor '

        public BaseElasticSearchClientProvider()
        {
            esNode = new Uri("http://localhost:9200");
            esSettings = new ConnectionSettings(esNode);
            esSettings.DefaultIndex(def_index);
            esClient = new ElasticClient(esSettings);
        }

        #endregion

        #region ' Methods '

        public void Insert(TEntity obj)
        {
            esClient.Index(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            var result = esClient.Search<TEntity>(s => s
                            .Index(def_index)
                            .AllTypes()
                            .MatchAll()
                        //.Size(250)
                        );

            return result.Documents;
        }

        public TEntity GetById(Guid id)
        {
            var response = esClient.Get(new DocumentPath<TEntity>(id));
            return response.Source;
        }

        #endregion
    }
}
