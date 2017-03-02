using Project.Domain.Entities;

namespace Project.Application.Contracts.ElasticSearch
{
    public interface IPersonElasticSearchApplicationService : IBaseElasticSearchApplicationService<Person>
    {
    }
}
