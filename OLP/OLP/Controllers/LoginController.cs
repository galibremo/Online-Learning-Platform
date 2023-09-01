using BLL.Services;
using OLP.Models;
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
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(StudentLoginModel login)
        {
            try
            {
                var token = StudentAuthServices.Login(login.Username, login.Password, login.UserType);
                if (token != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, token);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Msg = "Username or password invalid" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
