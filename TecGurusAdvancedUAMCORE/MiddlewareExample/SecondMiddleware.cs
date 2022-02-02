using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.MiddlewareExample
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<Startup> _logger;
        public SecondMiddleware(RequestDelegate next, ILogger<Startup> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("MW2 Incoming Request");
            await _next.Invoke(context);
            //await context.Response.WriteAsync("Hola estoy cortando el middleware");

            _logger.LogInformation("MW2 OutComing Request");

        }
    }
}
