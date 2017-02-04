using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Domain.Services
{
    public class BookDomainService : BaseDomainService<Book, Guid>, IBookDomainService
    {
        private readonly IBookRepository repository;

        public BookDomainService(IBookRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public IQueryable<Book> FindByAvailability(bool loaned)
        {
            return repository.FindByAvailability(loaned);
        }

        public IQueryable<Book> FindByItemType(string type)
        {
            return repository.FindByItemType(type);
        }

        public IQueryable<Book> FindByKeyWord(string keyword)
        {
            return repository.FindByKeyWord(keyword);
        }
    }
}
