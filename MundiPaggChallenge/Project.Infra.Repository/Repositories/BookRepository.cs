using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Infra.Repository.Repositories
{
    public class BookRepository //: BaseRepository<Book, Guid>, IBookRepository
    {
        //public virtual IQueryable<Book> FindByAvailability(bool loaned)
        //{
        //    return context.Books.Where(b => b.Loan.Loaned == loaned);
        //}

        //public virtual IQueryable<Book> FindByKeyWord(string keyword)
        //{
        //    return context.Books.Where(b => b.Title.Contains(keyword)                   ||
        //                                    b.RegisterDate.ToString().Contains(keyword) ||
        //                                    b.ReleaseDate.ToString().Contains(keyword)  ||
        //                                    b.ItemType.ToString().Contains(keyword)     ||
        //                                    b.Genre.ToString().Contains(keyword) ||
        //                                    b.Loan.Loaned == (keyword == "Yes" ? true : keyword == "No" ? false : true)
        //                              );
        //}

        //public virtual IQueryable<Book> FindByItemType(string type)
        //{
        //    return context.Books.Where(b => b.ItemType.ToString().Contains(type));
        //}
    }
}
