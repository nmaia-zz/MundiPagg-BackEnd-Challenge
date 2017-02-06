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
    [RoutePrefix("api/book")]
    public class BookController : ApiController
    {
        private readonly IBookApplicationService appBook;

        public BookController(IBookApplicationService appBook)
        {
            this.appBook = appBook;
        }

        [HttpPost]
        [Route("register")] //url: /api/book/register
        public HttpResponseMessage Post(BookModelRegister model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Book b = Mapper.Map<BookModelRegister, Book>(model);
                    appBook.Insert(b);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("edition")] //url: /api/book/edition
        public HttpResponseMessage Put(BookModelEdition model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Book b = Mapper.Map<BookModelEdition, Book>(model);
                    appBook.Update(b);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")] //url: /api/book/delete/id
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                Book b = appBook.FindById(id);

                if (b != null)
                {
                    appBook.Delete(b);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new Exception("Book not found.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("list")] //url: /api/book/list
        public HttpResponseMessage List()
        {
            try
            {
                var booksList = new List<BookModelConsultation>();

                foreach (Book b in appBook.FindAll())
                {
                    booksList.Add(Mapper.Map<Book, BookModelConsultation>(b));
                }

                return Request.CreateResponse(HttpStatusCode.OK, booksList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")] //url: /api/book/get/id
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                Book b = appBook.FindById(id);

                if (b != null)
                {
                    var model = Mapper.Map<Book, BookModelConsultation>(b);

                    return Request.CreateResponse(HttpStatusCode.OK, model);
                }
                else
                {
                    throw new Exception("Book not found.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        private List<string> GetErrorMessages()
        {
            var errorsList = new List<string>();

            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    errorsList.Add(error.ErrorMessage);
                }
            }

            return errorsList;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            appBook.Dispose();
        }
    }
}
