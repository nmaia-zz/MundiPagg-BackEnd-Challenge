using Project.Domain.Entities;
using System;

namespace Project.Domain.Contracts.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person, Guid>
    {
    }
}
