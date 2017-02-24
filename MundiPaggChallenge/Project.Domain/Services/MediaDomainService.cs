using Project.Domain.Contracts.Repositories;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Domain.Services
{
    //public class MediaDomainService : BaseDomainService<Media, Guid>, IMediaDomainService
    //{
    //    private readonly IMediaRepository repository;

    //    public MediaDomainService(IMediaRepository repository) : base(repository)
    //    {
    //        this.repository = repository;
    //    }

    //    public IQueryable<Media> FindByAvailability(bool loaned)
    //    {
    //        return repository.FindByAvailability(loaned);
    //    }

    //    public IQueryable<Media> FindByItemType(string type)
    //    {
    //        return repository.FindByItemType(type);
    //    }

    //    public IQueryable<Media> FindByKeyWord(string keyword)
    //    {
    //        return repository.FindByKeyWord(keyword);
    //    }

    //    public IQueryable<Media> FindByMediaType(string type)
    //    {
    //        return repository.FindByMediaType(type);
    //    }
    //}
}
