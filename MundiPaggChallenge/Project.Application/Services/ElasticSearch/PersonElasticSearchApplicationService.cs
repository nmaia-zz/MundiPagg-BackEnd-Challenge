using Project.Application.Contracts.ElasticSearch;
using Project.Domain.Contracts.Services.ElasticSearch;
using Project.Domain.Entities;

namespace Project.Application.Services.ElasticSearch
{
    public class PersonElasticSearchApplicationService
        : BaseElasticSearchApplicationService<Person>
        , IPersonElasticSearchApplicationService
    {
        private readonly IPersonDomainElasticSearchService _domainService;

        public PersonElasticSearchApplicationService(IPersonDomainElasticSearchService domainService)
            : base(domainService)
        {
            _domainService = domainService;
        }
    }
}
