using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;

namespace Project.Application.Services
{
    public class PersonApplicationService : BaseApplicationService<Person, Guid>, IPersonApplicationService
    {
        private readonly IPersonDomainService domain;

        public PersonApplicationService(IPersonDomainService domain) : base(domain)
        {
            this.domain = domain;
        }
    }
}
