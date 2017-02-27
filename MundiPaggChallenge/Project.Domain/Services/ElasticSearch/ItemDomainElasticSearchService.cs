using Project.Domain.Entities;
using Project.Domain.Contracts.Services.ElasticSearch;
using Project.Domain.Contracts.ESClientProvider;

namespace Project.Domain.Services.ElasticSearch
{
    public class ItemDomainElasticSearchService
        : BaseDomainElasticSearchService<Item>
        , IItemDomainElasticSearchService
    {
        private readonly IItemElasticSearchClientProvider _esClient;

        public ItemDomainElasticSearchService(IItemElasticSearchClientProvider esClient) 
            : base(esClient)
        {
            _esClient = esClient;
        }

        //ToDo: Implement the specific methods for Items
    }
}
