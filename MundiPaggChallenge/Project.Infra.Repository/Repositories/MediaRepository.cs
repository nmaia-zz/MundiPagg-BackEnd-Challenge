using Project.Domain.Contracts.Repositories;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infra.Repository.Repositories
{
    public class MediaRepository //: BaseRepository<Media, Guid>, IMediaRepository
    {
        //public virtual IQueryable<Media> FindByAvailability(bool loaned)
        //{
        //    return context.Medias.Where(b => b.Loan.Loaned == loaned);
        //}

        //public virtual IQueryable<Media> FindByKeyWord(string keyword)
        //{
        //    return context.Medias.Where(m => m.Title.Contains(keyword) ||
        //                                     m.RegisterDate.ToString().Contains(keyword) ||
        //                                     m.ReleaseDate.ToString().Contains(keyword) ||
        //                                     m.ItemType.ToString().Contains(keyword) ||
        //                                     m.Genre.ToString().Contains(keyword) ||
        //                                     m.Loan.Loaned == (keyword == "Yes" ? true : keyword == "No" ? false : true)
        //                                );
        //}

        //public virtual IQueryable<Media> FindByItemType(string type) 
        //{
        //    return context.Medias.Where(m => m.ItemType.ToString().Contains(type));
        //}

        //public virtual IQueryable<Media> FindByMediaType(string type)
        //{
        //    return context.Medias.Where(m => m.MediaType.ToString().Contains(type));
        //}
    }
}
