using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Domain.Contracts.Repositories
{
    public interface IBookRepository : IBaseRepository<Book, Guid>
    {
        IQueryable<Book> FindByItemType(string type);
        IQueryable<Book> FindByAvailability(bool loaned);
        IQueryable<Book> FindByKeyWord(string keyword);
    }
}
