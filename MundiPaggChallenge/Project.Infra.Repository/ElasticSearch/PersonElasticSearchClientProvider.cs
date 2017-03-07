using Project.Domain.Contracts.ESClientProvider;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infra.Repository.ElasticSearch
{
    public class PersonElasticSearchClientProvider 
        : BaseElasticSearchClientProvider<Person>
        , IPersonElasticSearchClientProvider
    {

    }
}
