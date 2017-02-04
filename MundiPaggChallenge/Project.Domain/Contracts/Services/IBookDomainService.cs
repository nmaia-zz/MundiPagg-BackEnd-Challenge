using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Domain.Contracts.Services
{
    public interface IBookDomainService : IBaseDomainService<Book, Guid>
    {
        IQueryable<Book> FindByItemType(string type);
        IQueryable<Book> FindByAvailability(bool loaned);
        IQueryable<Book> FindByKeyWord(string keyword);
    }
}
