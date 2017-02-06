using Project.Application.Contracts;
using Project.Domain.Contracts.Services;
using Project.Domain.Entities;
using System;
using System.Linq;

namespace Project.Application.Services
{
    public class MediaApplicationService : BaseApplicationService<Media, Guid>, IMediaApplicationService
    {
        private readonly IMediaDomainService domain;

        public MediaApplicationService(IMediaDomainService domain) : base(domain)
        {
            this.domain = domain;
        }

        public IQueryable<Media> FindByItemType(string type)
        {
            return domain.FindByItemType(type);
        }

        public IQueryable<Media> FindByMediaType(string type)
        {
            return domain.FindByMediaType(type);
        }

        public IQueryable<Media> FindByAvailability(bool loaned)
        {
            return domain.FindByAvailability(loaned);
        }

        public IQueryable<Media> FindByKeyWord(string keyword)
        {
            return domain.FindByKeyWord(keyword);
        }
    }
}
