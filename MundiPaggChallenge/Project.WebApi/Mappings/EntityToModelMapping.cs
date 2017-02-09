using AutoMapper;
using Project.Domain.Entities;
using Project.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebApi.Mappings
{
    public class EntityToModelMapping : Profile
    {
        protected override void Configure()
        {
            #region ' Person '

            Mapper.CreateMap<Person, PersonModelConsultation>();

            #endregion

            #region ' Loan '

            Mapper.CreateMap<Loan, LoanModelConsultation>();

            #endregion

            #region ' Book '

            Mapper.CreateMap<Book, BookModelConsultation>();

            #endregion

            #region ' Media '

            Mapper.CreateMap<Media, MediaModelConsultation>();

            #endregion
        }
    }
}