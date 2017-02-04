using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Services
{
    public class PersonDomainService : BaseDomainService<Person, Guid>, IPersonDomainService
    {
        private readonly IPersonRepository repository;

        public PersonDomainService(IPersonRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
