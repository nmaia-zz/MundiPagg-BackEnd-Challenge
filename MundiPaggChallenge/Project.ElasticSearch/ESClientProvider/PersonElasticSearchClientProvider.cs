using Project.Domain.Contracts.ESClientProvider;
using Project.Domain.Entities;
using System;

namespace Project.ElasticSearch.ESClientProvider
{
    public class PersonElasticSearchClientProvider
        : BaseElasticSearchClientProvider<Person>
        , IBaseElasticSearchClientProvider<Person>
    {
    }
}
