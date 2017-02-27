using Project.Domain.Contracts.ESClientProvider;
using Project.Domain.Contracts.Services.ElasticSearch;
using Project.Domain.Entities;

namespace Project.Domain.Services.ElasticSearch
{
    public class PersonDomainElasticSearchService 
        : BaseDomainElasticSearchService<Person>
        , IPersonDomainElasticSearchService
    {
        //private readonly IPersonElasticSearchClientProvider _esClient;

        public PersonDomainElasticSearchService(IPersonElasticSearchClientProvider esClient)
            : base(esClient)
        {
            //_esClient = esClient;
        }
    }
}
