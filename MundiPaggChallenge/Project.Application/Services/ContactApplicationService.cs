using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;

namespace Project.Application.Services
{
    public class ContactApplicationService : BaseApplicationService<Contact, Guid>, IContactApplicationService
    {
        private readonly IContactDomainService domain;

        public ContactApplicationService(IContactDomainService domain) : base(domain)
        {
            this.domain = domain;
        }
    }
}
