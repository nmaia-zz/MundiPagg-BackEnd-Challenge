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
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        private readonly IPersonApplicationService appPerson;

        public PersonController(IPersonApplicationService appPerson)
        {
            this.appPerson = appPerson;
        } 

        [HttpPost]
        [Route("register")] //url: /api/person/register
        public HttpResponseMessage Post(PersonModelRegister model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Person p = Mapper.Map<PersonModelRegister, Person>(model);
                    appPerson.Insert(p);

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
        [Route("edition")] //url: /api/person/edition
        public HttpResponseMessage Put(PersonModelEdition model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Person p = Mapper.Map<PersonModelEdition, Person>(model);
                    appPerson.Update(p);

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
        [Route("delete/{id}")] //url: /api/person/delete/id
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                Person p = appPerson.FindById(id);

                if (p != null)
                {
                    appPerson.Delete(p);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new Exception("Person not found.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("list")] //url: /api/person/list
        public HttpResponseMessage List()
        {
            try
            {
                var personsList = new List<PersonModelConsultation>();

                foreach (Person p in appPerson.FindAll())
                {
                    personsList.Add(Mapper.Map<Person, PersonModelConsultation>(p));
                }

                return Request.CreateResponse(HttpStatusCode.OK, personsList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")] //url: /api/person/get/id
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                Person p = appPerson.FindById(id);

                if (p != null)
                {
                    var model = Mapper.Map<Person, PersonModelConsultation>(p);

                    return Request.CreateResponse(HttpStatusCode.OK, model);
                }
                else
                {
                    throw new Exception("Person not found.");
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
            appPerson.Dispose();
        }
    }
}
