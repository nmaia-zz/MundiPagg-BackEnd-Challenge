using Project.Application.Contracts.ElasticSearch;
using Project.Domain.Contracts.Services.ElasticSearch;
using Project.Domain.Entities;

namespace Project.Application.Services.ElasticSearch
{
    public class ItemElasticSearchApplicationService 
        : BaseElasticSearchApplicationService<Item>
        , IItemElasticSearchApplicationService
    {
        private readonly IItemDomainElasticSearchService _domainService;

        public ItemElasticSearchApplicationService(IItemDomainElasticSearchService domainService)
            : base(domainService)
        {
            _domainService = domainService;
        }
    }
}
