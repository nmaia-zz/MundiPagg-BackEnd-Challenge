using System;
using System.Collections.Generic;

namespace Project.ElasticSearch.ClientProvider
{
    public class BaseElasticSearchClientProvider<TEntity> //: IBaseElasticSearchClientProvider<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
