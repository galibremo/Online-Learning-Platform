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
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/Student/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = StudentServices.Get();   
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Student/{id}/MyCourse")]
        public HttpResponseMessage GetWithCat(int id)
        {
            try
            {
                var data = StudentServices.GetWithStnt(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/Student/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = StudentServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/Student/Insert")]
        public HttpResponseMessage Create(StudentDTO s)
        {
            try
            {
                var data = StudentServices.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/Student/Update")]
        public HttpResponseMessage Update(StudentDTO s)
        {
            try
            {
                var data = StudentServices.Update(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/Student/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = StudentServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}