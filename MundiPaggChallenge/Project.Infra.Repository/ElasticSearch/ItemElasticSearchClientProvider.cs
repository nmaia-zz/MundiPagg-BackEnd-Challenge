using Project.Domain.Contracts.ESClientProvider;
using Project.Domain.Entities;

namespace Project.Infra.Repository.ElasticSearch
{
    public class ItemElasticSearchClientProvider
        : BaseElasticSearchClientProvider<Item>
        , IItemElasticSearchClientProvider
    {
    }
}
