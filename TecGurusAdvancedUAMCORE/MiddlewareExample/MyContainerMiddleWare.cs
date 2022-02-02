using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.MiddlewareExample
{
    public static class MyContainerMiddleWare
    {
        public static IApplicationBuilder UseCustomeMiddleWare(this IApplicationBuilder app, ILogger<Startup> logger)
        {
            //Va a crecer el Pipeline ya que vamos a llamar el Middleware 1 2 y 3
            app.UseMiddleware<FirstMiddleware>(logger);
            app.UseMiddleware<SecondMiddleware>(logger);
            app.UseMiddleware<ThirdMiddleware>(logger);
            return app;
        }
    }
}
