using Project.Domain.Entities;
using System;

namespace Project.Domain.Contracts.Services
{
    public interface IPersonDomainService : IBaseDomainService<Person, Guid>
    {

    }
}
