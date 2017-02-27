using Project.Domain.Entities;

namespace Project.Domain.Contracts.ESClientProvider
{
    public interface IPersonElasticSearchClientProvider : IBaseElasticSearchClientProvider<Person>
    {
    }
}
