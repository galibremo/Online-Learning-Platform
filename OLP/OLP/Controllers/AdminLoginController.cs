using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using OLP.Models;
using BLL.Services;
using System.Web.Http.Cors;

namespace OLP.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminLoginController : ApiController
    {
        [HttpPost]
        [Route("api/admin/login")]
        public HttpResponseMessage AdminLogin(AdminLoginModel a)
        {
            try
            {
                var key = AdminAuth.Login(a.username, a.password);
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