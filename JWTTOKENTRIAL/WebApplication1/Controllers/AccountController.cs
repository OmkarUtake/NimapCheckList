using JWTApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ValidLogin(string username, string password)
        {
            if(username=="admin" && password == "admin")
            {
                return Request.CreateResponse(HttpStatusCode.OK, value: TokenManager.GenerateToken(username));

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, message: "Wrong input");
            }
        }
    }
}
