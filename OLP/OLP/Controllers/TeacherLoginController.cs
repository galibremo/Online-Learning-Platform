using BLL.Services;
using OLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OLP.Controllers
{
    public class TeacherLoginController : ApiController
    {
        [HttpPost]
        [Route("api/teacher/login")]
        public HttpResponseMessage TeacherLogin(TeacherLoginModel t)
        {
            try
            {
                var key = TeacherAuth.Login(t.username, t.password);
                if (key != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, key);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { msg = "Username or password not found" });
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
