using BLL.DTOs;
using BLL.Services;
using OLP.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OLP.Controllers
{
    [EnableCors("*", "*", "*")]
    public class MyCourseController : ApiController
    {
        [Logged]
        [HttpGet]
        [Route("api/MyCourse/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = MyCourseServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyCourse/Title/{title}")]
        public HttpResponseMessage GetByTitle(string title)
        {
            try
            {
                var data = MyCourseServices.GetTitle(title);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyCourse/Status/{status}")]
        public HttpResponseMessage GetStatus(string status)
        {
            try
            {
                var data = MyCourseServices.GetByStatus(status);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyCourse/{id}/WatchList")]
        public HttpResponseMessage GetCrsWL(int id)
        {
            try
            {
                var data = MyCourseServices.GetCrsWL(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyCourse/{title}/Student")]
        public HttpResponseMessage GetWithTitle(string title)
        {
            try
            {
                var data = MyCourseServices.GetWithTitle(title);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyCourse/Date/{date}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            try
            {
                var data = MyCourseServices.Get(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyCourse/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = MyCourseServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyCourse/Insert")]
        public HttpResponseMessage Create(MyCourseDTO c)
        {
            try
            {
                var data = MyCourseServices.Create(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyCourse/Update")]
        public HttpResponseMessage Update(MyCourseDTO c)
        {
            try
            {
                var data = MyCourseServices.Update(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyCourse/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = MyCourseServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}