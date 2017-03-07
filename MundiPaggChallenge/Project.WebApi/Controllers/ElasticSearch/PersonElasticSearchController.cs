using AutoMapper;
using Project.Application.Contracts.ElasticSearch;
using Project.Domain.Entities;
using Project.WebApi.Models.ElasticSearch;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.WebApi.Controllers.ElasticSearch
{
    [RoutePrefix("api/elasticsearch/person")]
    public class PersonElasticSearchController : ApiController
    {
        private readonly IPersonElasticSearchApplicationService _elasticSerarchAppServicePerson;

        public PersonElasticSearchController(IPersonElasticSearchApplicationService elasticSerarchAppServicePerson)
        {
            _elasticSerarchAppServicePerson = elasticSerarchAppServicePerson;
        }

        [HttpPost]
        [Route("register")] //url: /api/elasticsearch/person/register
        public HttpResponseMessage Post(PersonRegisterElasticSearchModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Person p = Mapper.Map<PersonRegisterElasticSearchModel, Person>(model);

                    _elasticSerarchAppServicePerson.Insert(p);

                    return Request.CreateResponse(HttpStatusCode.OK, "Person has been registred.");
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
    }
}