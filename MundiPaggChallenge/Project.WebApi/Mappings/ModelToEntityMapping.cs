using AutoMapper;
using Project.Domain.Entities;
using Project.WebApi.Models;
using Project.WebApi.Models.ElasticSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebApi.Mappings
{
    public class ModelToEntityMapping : Profile
    {
        protected override void Configure()
        {
            #region ' Person '

            Mapper.CreateMap<PersonRegisterElasticSearchModel, Person>();
            Mapper.CreateMap<PersonEditionElasticSearchModel, Person>();

            #endregion

            #region ' Loan '

            //Mapper.CreateMap<LoanModelRegister, Loan>();
            //Mapper.CreateMap<LoanModelEdition, Loan>();

            #endregion

            #region ' Book '

            //Mapper.CreateMap<BookModelRegister, Book>();
            //Mapper.CreateMap<BookModelEdition, Book>();

            #endregion

            #region ' Media '

            //Mapper.CreateMap<MediaModelRegister, Media>();
            //Mapper.CreateMap<MediaModelEdition, Media>();

            #endregion
        }
    }
}