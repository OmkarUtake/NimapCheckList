//using JWTApi;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Http;
//using System.Web.Http.Filters;

//namespace WebApplication1
//{
//    public class CustomAuth : AuthorizeAttribute, IAuthenticationFilter
//    {
//        public bool AllowMultiple
//        {
//            get { return false; }

//        }

//        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
//        {
//            string authParameter = string.Empty;
//            HttpRequestMessage request = context.Request;
//            AuthenticationHeaderValue autherization = request.Headers.Authorization;
//            if (autherization == null)
//            {
//                context.ErrorResult = new AuthenticationFailureResult(reasonPhrase:"Missing Header",request);
//            }
//            if(autherization.Scheme != "Bearer")
//            {
//                context.ErrorResult = new AuthenticationFailureResult(reasonPhrase: "Invalid Schema", request);
//            }
//            if (String.IsNullOrEmpty(autherization.Parameter))
//            {
//                context.ErrorResult = new AuthenticationFailureResult(reasonPhrase: "Missing Token", request);
//            }
//            context.Principal = TokenManager.GetPrincipal(autherization.Parameter);
//        }

//        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class AuthenticationFailureResult : IHttpActionResult
//    {

//        public string ReasonPhrase;
//        public HttpRequestMessage Request { get; set; }

//        public AuthenticationFailureResult(string reasonPhrase, HttpRequestMessage request)
//        {
//            ReasonPhrase = reasonPhrase;
//            Request = request;
//        }

//        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }

//        public HttpResponseMessage Execute()
//        {
//            HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
//            response.RequestMessage = Request;
//            response.ReasonPhrase = ReasonPhrase;
//            return response;

//        }

//    }

//}