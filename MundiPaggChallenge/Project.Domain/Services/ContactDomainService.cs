using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;

namespace Project.Domain.Services
{
    public class ContactDomainService : BaseDomainService<Contact, Guid>, IContactDomainService
    {
        private readonly IContactRepository repository;

        public ContactDomainService(IContactRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
