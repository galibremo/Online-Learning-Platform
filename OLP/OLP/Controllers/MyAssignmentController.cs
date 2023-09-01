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
    public class MyAssignmentController : ApiController
    {
        [Logged]
        [HttpGet]
        [Route("api/MyAssignment/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = MyAssignmentServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyAssignment/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = MyAssignmentServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/MyAssignment/Insert")]
        public HttpResponseMessage Create(MyAssignmentDTO a)
        {
            try
            {
                var data = MyAssignmentServices.Create(a);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyAssignment/Update")]
        public HttpResponseMessage Update(MyAssignmentDTO a)
        {
            try
            {
                var data = MyAssignmentServices.Update(a);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/MyAssignment/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = MyAssignmentServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}