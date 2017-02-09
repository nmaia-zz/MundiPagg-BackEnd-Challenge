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
    [RoutePrefix("api/media")]
    public class MediaController : ApiController
    {
        private readonly IMediaApplicationService appMedia;
        private readonly ILoanApplicationService appLoan;

        public MediaController(IMediaApplicationService appMedia, ILoanApplicationService appLoan)
        {
            this.appMedia = appMedia;
            this.appLoan = appLoan;
        }

        [HttpPost]
        [Route("register")] //url: /api/media/register
        public HttpResponseMessage Post(MediaModelRegister model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Loan l = new Loan();
                    appLoan.Insert(l);

                    Media m = Mapper.Map<MediaModelRegister, Media>(model);
                    m.Loan = l;

                    appMedia.Insert(m);

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
        [Route("edition")] //url: /api/media/edition
        public HttpResponseMessage Put(MediaModelEdition model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Media m = Mapper.Map<MediaModelEdition, Media>(model);
                    appMedia.Update(m);

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
        [Route("delete/{id}")] //url: /api/media/delete/id
        public HttpResponseMessage Delete(Guid id)
        {
            try
            {
                Media m = appMedia.FindById(id);

                if(m != null)
                {
                    appMedia.Delete(m);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new Exception("Media not found.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("list")] //url: /api/media/list
        public HttpResponseMessage List()
        {
            try
            {
                var mediasList = new List<MediaModelConsultation>();

                foreach (Media m in appMedia.FindAll())
                {
                    mediasList.Add(Mapper.Map<Media, MediaModelConsultation>(m));
                }

                return Request.CreateResponse(HttpStatusCode.OK, mediasList);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")] //url: /api/media/get/id
        public HttpResponseMessage GetValue(Guid id)
        {
            try
            {
                Media m = appMedia.FindById(id);

                if (m != null)
                {
                    var model = Mapper.Map<Media, MediaModelConsultation>(m);

                    return Request.CreateResponse(HttpStatusCode.OK, model);
                }
                else
                {
                    throw new Exception("Media not found.");
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
            appMedia.Dispose();
        }
    }
}
