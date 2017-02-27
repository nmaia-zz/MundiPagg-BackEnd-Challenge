using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Application.Services
{
    public class BookApplicationService //: BaseApplicationService<Book, Guid>, IBookApplicationService
    {
        //private readonly IBookDomainService domain;

        //public BookApplicationService(IBookDomainService domain) : base(domain)
        //{
        //    this.domain = domain;
        //}

        //public IQueryable<Book> FindByItemType(string type)
        //{
        //    return domain.FindByItemType(type);
        //}

        //public IQueryable<Book> FindByAvailability(bool loaned)
        //{
        //    return domain.FindByAvailability(loaned);
        //}

        //public IQueryable<Book> FindByKeyWord(string keyword)
        //{
        //    return domain.FindByKeyWord(keyword);
        //}
    }
}
