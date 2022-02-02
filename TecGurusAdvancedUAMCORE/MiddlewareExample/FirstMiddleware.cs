using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.MiddlewareExample
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<Startup> _logger;
        public FirstMiddleware(RequestDelegate next, ILogger<Startup> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("MW1 Incoming Request");
            await _next.Invoke(context);
            _logger.LogInformation("MW1 OutComing Request");

        }

    }
}
