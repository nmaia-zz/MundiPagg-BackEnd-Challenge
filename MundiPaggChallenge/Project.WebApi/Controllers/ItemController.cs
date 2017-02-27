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
        private readonly IPersonApplicationService appPerson;

        public ItemController(IBookApplicationService appBook,
                            IMediaApplicationService appMedia,
                            ILoanApplicationService appLoan,
                            IPersonApplicationService appPerson)
        {
            this.appBook = appBook;
            this.appMedia = appMedia;
            this.appLoan = appLoan;
            this.appPerson = appPerson;
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

                //foreach (Book b in appBook.FindAll())
                //{
                //    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                //}

                //foreach (Media m in appMedia.FindAll())
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                foreach (var item in booksList)
                {
                    //var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        //Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    //var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        //Loaned = loan.Loaned
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
        [Route("list/onlyAvailableToLoan")] //url: /api/item/list/onlyAvailableToLoan
        public HttpResponseMessage ListByAvailability()
        {
            try
            {
                var booksList = new List<BookModelConsultation>();
                var mediasList = new List<MediaModelConsultation>();
                var itemsList = new List<ItemModelConsultation>();

                //foreach (Book b in appBook.FindByAvailability(false))
                //{
                //    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                //}

                //foreach (Media m in appMedia.FindByAvailability(false))
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                foreach (var item in booksList)
                {
                    //var loan = appLoan.FindById(item.LoanId);

                    var x = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        //Loaned = loan.Loaned
                    };

                    itemsList.Add(x);
                }

                foreach (var item in mediasList)
                {
                    //var loan = appLoan.FindById(item.LoanId);

                    var y = new ItemModelConsultation()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        ItemType = item.ItemType,
                        Genre = item.Genre,
                        RegisterDate = item.RegisterDate,
                        ReleaseDate = item.ReleaseDate,
                        //Loaned = loan.Loaned
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
        [Route("get/{id}")] //url: /api/item/get/{id}
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                //Book b = appBook.FindById(id);
                //Media m = appMedia.FindById(id);

                //if (b != null)
                //{
                //    var model = Mapper.Map<Book, BookModelConsultation>(b);

                //    var loan = appLoan.FindById(model.LoanId);
                //    model.Loaned = loan.Loaned;

                //    if (loan.PersonId != null)
                //    {
                //        var guid = Guid.Parse(loan.PersonId.ToString());

                //        var person = appPerson.FindById(guid);

                //        if (person != null)
                //        {
                //            var c = appContact.
                //            model.FirstName = person.FirstName;
                //            model.Cellphone = person.Cellphone;
                //        }
                //    }

                    return Request.CreateResponse(HttpStatusCode.OK/*, model*/);
                //}
                //else if (m != null)
                //{
                //    var model = Mapper.Map<Media, MediaModelConsultation>(m);

                //    var loan = appLoan.FindById(model.LoanId);
                //    model.Loaned = loan.Loaned;

                //    if (loan.PersonId != null)
                //    {
                //        var guid = Guid.Parse(loan.PersonId.ToString());

                //        var person = appPerson.FindById(guid);

                //        if (person != null)
                //        {
                //            model.FirstName = person.FirstName;
                //            model.Cellphone = person.Cellphone;
                //        }
                //    }

                //    return Request.CreateResponse(HttpStatusCode.OK, model);
                //}
                //else
                //{
                //    throw new Exception("Item not found.");
                //}
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")] //url: /api/item/delete/{id}
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                //Book b = appBook.FindById(id);
                //Media m = appMedia.FindById(id);

                //if (b != null)
                //{
                //    var loan = appLoan.FindById(b.LoanId);

                //    if (loan.Loaned == false)
                //    {
                //        appBook.Delete(b);

                        return Request.CreateResponse(HttpStatusCode.OK);
                //    }
                //    else
                //    {
                //        throw new Exception("This Item cannot be deleted. It's currently loaned. Check it before deleting.");
                //    }
                //}
                //else if (m != null)
                //{
                //    var loan = appLoan.FindById(m.LoanId);

                //    if (loan.Loaned == false)
                //    {
                //        appMedia.Delete(m);

                //        return Request.CreateResponse(HttpStatusCode.OK);
                //    }
                //    else
                //    {
                //        throw new Exception("This Item cannot be deleted. It's currently loaned. Check it before deleting.");
                //    }
                //}
                //else
                //{
                //    throw new Exception("Item not found.");
                //}
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("edition")] //url: /api/item/edition
        public HttpResponseMessage Put(ItemModelEdition model)
        {
            try
            {
                //var loan = appLoan.FindById(model.LoanId);

                //if (loan.Loaned == true)
                //{
                //    loan.Loaned = false;
                //    appLoan.Update(loan);
                //}
                //else
                //{
                //    throw new Exception("It is not possible to change the loan status (false => true) without associating a person to the item.");
                //}

                return Request.CreateResponse(HttpStatusCode.OK);
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
                //var booksList = new List<BookModelConsultation>();
                //var mediasList = new List<MediaModelConsultation>();
                //var itemsList = new List<ItemModelConsultation>();

                //foreach (Book b in appBook.FindByItemType(type))
                //{
                //    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                //}

                //foreach (Media m in appMedia.FindByItemType(type))
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                //foreach (var item in booksList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var x = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(x);
                //}

                //foreach (var item in mediasList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var y = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(y);
                //}

                return Request.CreateResponse(HttpStatusCode.OK/*, itemsList*/);
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
                //var booksList = new List<BookModelConsultation>();
                //var mediasList = new List<MediaModelConsultation>();
                //var itemsList = new List<ItemModelConsultation>();

                //foreach (Book b in appBook.FindByKeyWord(keyword))
                //{
                //    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                //}

                //foreach (Media m in appMedia.FindByKeyWord(keyword))
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                //foreach (var item in booksList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var x = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(x);
                //}

                //foreach (var item in mediasList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var y = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(y);
                //}

                return Request.CreateResponse(HttpStatusCode.OK/*, itemsList*/);
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
                //var booksList = new List<BookModelConsultation>();
                //var mediasList = new List<MediaModelConsultation>();
                //var itemsList = new List<ItemModelConsultation>();

                //foreach (Book b in appBook.FindByAvailability(loaned))
                //{
                //    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                //}

                //foreach (Media m in appMedia.FindByAvailability(loaned))
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                //foreach (var item in booksList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var x = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(x);
                //}

                //foreach (var item in mediasList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var y = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(y);
                //}

                return Request.CreateResponse(HttpStatusCode.OK/*, itemsList*/);
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
                //var booksList = new List<BookModelConsultation>();
                //var mediasList = new List<MediaModelConsultation>();
                //var itemsList = new List<ItemModelConsultation>();

                //foreach (Media m in appMedia.FindByMediaType(type))
                //{
                //    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                //}

                //foreach (var item in mediasList)
                //{
                //    var loan = appLoan.FindById(item.LoanId);

                //    var x = new ItemModelConsultation()
                //    {
                //        Id = item.Id,
                //        Title = item.Title,
                //        ItemType = item.ItemType,
                //        Genre = item.Genre,
                //        RegisterDate = item.RegisterDate,
                //        ReleaseDate = item.ReleaseDate,
                //        Loaned = loan.Loaned
                //    };

                //    itemsList.Add(x);
                //}

                return Request.CreateResponse(HttpStatusCode.OK/*, itemsList*/);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        #endregion
    }
}
