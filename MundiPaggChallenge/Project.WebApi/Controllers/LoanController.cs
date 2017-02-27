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
    [RoutePrefix("api/loan")]
    public class LoanController : ApiController
    {
        private readonly ILoanApplicationService appLoan;
        private readonly IBookApplicationService appBook;
        private readonly IMediaApplicationService appMedia;
        private readonly IPersonApplicationService appPerson;

        public LoanController(ILoanApplicationService appLoan, IBookApplicationService appBook, IMediaApplicationService appMedia, IPersonApplicationService appPerson)
        {
            this.appLoan = appLoan;
            this.appBook = appBook;
            this.appMedia = appMedia;
            this.appPerson = appPerson;
        }

        [HttpPost]
        [Route("register")] //url: /api/loan/register
        public HttpResponseMessage Post(LoanModelRegister model)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                //    if (model.Loaned == false)
                //    {
                //        var book = appBook.FindById(model.ItemId);
                //        var media = appMedia.FindById(model.ItemId);

                //        Loan l = Mapper.Map<LoanModelRegister, Loan>(model);
                //        //l.PersonId = model.PersonId;
                //        l.Loaned = true;

                //        var guid = Guid.Parse(model.PersonId.ToString());

                //        if (book != null)
                //        {
                //            var loan = appLoan.FindById(book.LoanId);
                //            loan.Loaned = true;
                //            loan.Person = appPerson.FindById(guid);

                //        }
                //        else if (media != null)
                //        {
                //            var loan = appLoan.FindById(media.LoanId);
                //            loan.Loaned = true;
                //            loan.Person = appPerson.FindById(guid);
                //        }

                //        appLoan.Insert(l);
                //    }
                //    else
                //    {
                //        throw new Exception("This item is already loaned.");
                //    }

                    return Request.CreateResponse(HttpStatusCode.OK);
                //}
                //else
                //{
                //    var x = Request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
                //    return x;
                //}
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")] //url: /api/loan/delete/id
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                //Loan l = appLoan.FindById(id);

                //if (l != null)
                //{
                //    appLoan.Delete(l);

                    return Request.CreateResponse(HttpStatusCode.OK);
                //}
                //else
                //{
                //    throw new Exception("Loan not found.");
                //}
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("list")] //url: /api/loan/list
        public HttpResponseMessage List()
        {
            try
            {
                //var loansList = new List<LoanModelConsultation>();

                //foreach (Loan l in appLoan.FindAll())
                //{
                //    loansList.Add(Mapper.Map<Loan, LoanModelConsultation>(l));
                //}

                return Request.CreateResponse(HttpStatusCode.OK/*, loansList*/);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")] //url: /api/loan/get/id
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                //Loan l = appLoan.FindById(id);

                //if (l != null)
                //{
                //    var model = Mapper.Map<Loan, LoanModelConsultation>(l);

                    return Request.CreateResponse(HttpStatusCode.OK/*, model*/);
                //}
                //else
                //{
                //    throw new Exception("Loan not found");
                //}
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
            //appLoan.Dispose();
        }
    }
}
