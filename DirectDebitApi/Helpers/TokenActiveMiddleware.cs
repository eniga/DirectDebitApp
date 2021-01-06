using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DirectDebitApi.Helpers
{
    public class TokenActiveMiddleware : IMiddleware
    {
        private readonly IJwtUtil jwtUtil;
        private readonly IHttpContextAccessor httpContextAccessor;
        // initialize middleware and inject interfaces
        public TokenActiveMiddleware(IJwtUtil jwtUtil, IHttpContextAccessor httpContextAccessor)
        {
            this.jwtUtil = jwtUtil;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // get token from header
            var token = jwtUtil.GetToken(httpContextAccessor);
            // check if the token is still active
            if (!await jwtUtil.IsActiveAsync(token))
            {
                // token is inactive and set to unauthorized
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                // set logout response
                await context.Response.WriteAsync("User token has been logged out");
                return;
            }

            await next(context);
        }
    }
}
