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
    [RoutePrefix("api/contact")]
    public class ContactController : ApiController
    {
        private readonly IContactApplicationService appContact;

        public ContactController(IContactApplicationService appContact)
        {
            this.appContact = appContact;
        }

        [HttpPost]
        [Route("register")] //url: /api/contact/register
        public HttpResponseMessage Post(ContactModelRegister model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contact c = Mapper.Map<ContactModelRegister, Contact>(model);

                    appContact.Insert(c);

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
        [Route("edition")] //url: /api/contact/edition
        public HttpResponseMessage Put(ContactModelEdition model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contact c = Mapper.Map<ContactModelEdition, Contact>(model);

                    appContact.Update(c);

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
        [Route("delete/{id}")] //url: /api/contact/delete/id
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                Contact c = appContact.FindById(id);

                if (c != null)
                {
                    appContact.Delete(c);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new Exception("Contact not found.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("list")] //url: /api/contact/list
        public HttpResponseMessage List()
        {
            try
            {
                var contactsList = new List<ContactModelConsultation>();

                foreach (Contact c in appContact.FindAll())
                {
                    contactsList.Add(Mapper.Map<Contact, ContactModelConsultation>(c));
                }

                return Request.CreateResponse(HttpStatusCode.OK, contactsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")] //url: /api/contact/get/id
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                Contact c = appContact.FindById(id);

                if (c != null)
                {
                    var model = Mapper.Map<Contact, ContactModelConsultation>(c);

                    return Request.CreateResponse(HttpStatusCode.OK, model);
                }
                else
                {
                    throw new Exception("Contact not found.");
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
            appContact.Dispose();
        }
    }
}
