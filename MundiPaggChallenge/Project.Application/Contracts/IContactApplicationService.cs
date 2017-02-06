using Project.Domain.Entities;
using System;

namespace Project.Application.Contracts
{
    public interface IContactApplicationService : IBaseApplicationService<Contact, Guid>
    {

    }
}
