using Project.Domain.Entities;
using System;

namespace Project.Application.Contracts
{
    public interface IPersonApplicationService : IBaseApplicationService<Person, Guid>
    {

    }
}
