using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Application.Contracts
{
    public interface IMediaApplicationService : IBaseApplicationService<Media, Guid>
    {
        IQueryable<Media> FindByItemType(string type);
        IQueryable<Media> FindByMediaType(string type);
        IQueryable<Media> FindByAvailability(bool loaned);
        IQueryable<Media> FindByKeyWord(string keyword);
    }
}
