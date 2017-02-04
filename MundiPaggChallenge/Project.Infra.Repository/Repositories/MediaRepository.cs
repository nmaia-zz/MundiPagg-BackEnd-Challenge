using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infra.Repository.Repositories
{
    public class MediaRepository : BaseRepository<Media, Guid>, IMediaRepository
    {
        public virtual IQueryable<Media> FindByAvailability(bool loaned)
        {
            return context.Books.Select(m =>
                        new Media()
                        {
                            Title = m.Title,
                            RegisterDate = m.RegisterDate,
                            ReleaseDate = m.ReleaseDate,
                            ItemType = m.ItemType,
                            Genre = m.Genre
                        }
                   ).Where(b => b.Loan.Loaned == loaned);
        }

        public virtual IQueryable<Media> FindByKeyWord(string keyword)
        {
            return context.Books.Select(m =>
                        new Media()
                        {
                            Title = m.Title,
                            RegisterDate = m.RegisterDate,
                            ReleaseDate = m.ReleaseDate,
                            ItemType = m.ItemType,
                            Genre = m.Genre
                        }
                   ).Where(m => m.Title.Contains(keyword) ||
                                m.RegisterDate.ToString().Contains(keyword) ||
                                m.ReleaseDate.ToString().Contains(keyword) ||
                                m.ItemType.ToString().Contains(keyword) ||
                                m.Genre.ToString().Contains(keyword)
                          );
        }

        public virtual IQueryable<Media> FindByItemType(string type) 
        {
            return context.Books.Select(m =>
                       new Media()
                       {
                           Title = m.Title,
                           RegisterDate = m.RegisterDate,
                           ReleaseDate = m.ReleaseDate,
                           ItemType = m.ItemType,
                           Genre = m.Genre
                       }
                ).Where(m => m.ItemType.ToString().Contains(type));
        }

        public IQueryable<Media> FindByMediaType(string type)
        {
            return context.Books.Select(m =>
                       new Media()
                       {
                           Title = m.Title,
                           RegisterDate = m.RegisterDate,
                           ReleaseDate = m.ReleaseDate,
                           ItemType = m.ItemType,
                           Genre = m.Genre
                       }
                ).Where(m => m.MediaType.ToString().Contains(type));
        }
    }
}
