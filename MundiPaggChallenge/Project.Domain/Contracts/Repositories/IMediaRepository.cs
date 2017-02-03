using Project.Domain.Entities;
using System;

namespace Project.Domain.Contracts.Repositories
{
    public interface IMediaRepository : IBaseRepository<Media, Guid>
    {
    }
}
