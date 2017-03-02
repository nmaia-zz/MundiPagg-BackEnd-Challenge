using Project.Application.Contracts.ElasticSearch;
using Project.Domain.Contracts.Services.ElasticSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services.ElasticSearch
{
    public class BaseElasticSearchApplicationService<TEntity>
        : IBaseElasticSearchApplicationService<TEntity>
        where TEntity : class
    {
        private readonly IBaseDomainElasticSearchService<TEntity> _domainService;

        public BaseElasticSearchApplicationService(IBaseDomainElasticSearchService<TEntity> domainService)
        {
            _domainService = domainService;
        }

        public void Insert(TEntity obj)
        {
            _domainService.Insert(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _domainService.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _domainService.GetById(id);
        }
    }
}
