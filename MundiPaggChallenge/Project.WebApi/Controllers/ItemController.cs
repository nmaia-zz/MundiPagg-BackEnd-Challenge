using AutoMapper;
using Project.Application.Contracts;
using Project.Domain.Entities;
using Project.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebApi.Controllers
{
    [RoutePrefix("api/item")]
    public class ItemController : ApiController
    {
        private readonly IBookApplicationService appBook;
        private readonly IMediaApplicationService appMedia;
        private readonly ILoanApplicationService appLoan;

        public ItemController(IBookApplicationService appBook, IMediaApplicationService appMedia, ILoanApplicationService appLoan)
        {
            this.appBook = appBook;
            this.appMedia = appMedia;
            this.appLoan = appLoan;
        }

        [HttpGet]
        [Route("list")] //url: /api/item/list
        public HttpResponseMessage List()
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                foreach (Book b in appBook.FindAll())
                {
                    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                }

                foreach (Media m in appMedia.FindAll())
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                foreach (var item in booksList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(y);
                }

                return Request.CreateResponse(HttpStatusCode.OK, itemsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        #region ' Filters '

        [HttpGet]
        [Route("filterByItemType/{type}")]
        public HttpResponseMessage FilterByItemType(string type)
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                foreach (Book b in appBook.FindByItemType(type))
                {
                    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                }

                foreach (Media m in appMedia.FindByItemType(type))
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                foreach (var item in booksList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(y);
                }

                return Request.CreateResponse(HttpStatusCode.OK, itemsList);
            }
            catch (Exception ex) 
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("filterByKeyWord/{keyword}")]
        public HttpResponseMessage FilterByKeyWord(string keyword)
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                foreach (Book b in appBook.FindByKeyWord(keyword))
                {
                    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                }

                foreach (Media m in appMedia.FindByKeyWord(keyword))
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                foreach (var item in booksList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(y);
                }

                return Request.CreateResponse(HttpStatusCode.OK, itemsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("filterByAvailability/{loaned}")]
        public HttpResponseMessage FilterByAvailability(bool loaned)
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                foreach (Book b in appBook.FindByAvailability(loaned))
                {
                    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                }

                foreach (Media m in appMedia.FindByAvailability(loaned))
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                foreach (var item in booksList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(y);
                }

                return Request.CreateResponse(HttpStatusCode.OK, itemsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("filterByMediaType/{type}")]
        public HttpResponseMessage FilterByMediaType(string type)
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                foreach (Media m in appMedia.FindByMediaType(type))
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                foreach (var item in mediasList)
                {
                    var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                return Request.CreateResponse(HttpStatusCode.OK, itemsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        #endregion
    }
}
