using Project.Domain.Entities;

namespace Project.Domain.Contracts.ESClientProvider
{
    public interface IItemElasticSearchClientProvider : IBaseElasticSearchClientProvider<Item>
    {
    }
}
