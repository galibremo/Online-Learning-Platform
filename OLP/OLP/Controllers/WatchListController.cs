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
    public class WatchListController : ApiController
    {
        [HttpGet]
        [Route("api/WatchList/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = WatchListServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/WatchList/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = WatchListServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/WatchList/Insert")]
        public HttpResponseMessage Create(WatchListDTO w)
        {
            try
            {
                var data = WatchListServices.Create(w);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/WatchList/Update")]
        public HttpResponseMessage Update(WatchListDTO w)
        {
            try
            {
                var data = WatchListServices.Update(w);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/WatchList/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = WatchListServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
