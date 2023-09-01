using BLL.DTOs;
using BLL.Services;
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
    public class MySubmissionController : ApiController
    {
        [HttpGet]
        [Route("api/MySubmission/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = MySubmissionServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MySubmission/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = MySubmissionServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MySubmission/Insert/")]
        public HttpResponseMessage Create(MySubmissionDTO s)
        {
            try
            {
                var data = MySubmissionServices.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MySubmission/Update")]
        public HttpResponseMessage Update(MySubmissionDTO s)
        {
            try
            {
                var data = MySubmissionServices.Update(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MySubmission/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = MySubmissionServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}