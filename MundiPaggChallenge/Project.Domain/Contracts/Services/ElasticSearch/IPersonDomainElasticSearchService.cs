using Project.Domain.Entities;

namespace Project.Domain.Contracts.Services.ElasticSearch
{
    public interface IPersonDomainElasticSearchService : IBaseDomainElasticSearchService<Person>
    {
    }
}
