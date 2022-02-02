using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecGurusAdvancedUAMCORE.MiddleWareIdentityConfig
{
    public static class MiddleWareIdentity
    {
        public static async Task UseIdentityMiddleWare(this IApplicationBuilder app, IServiceProvider service)
        {
            var RoleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            var rolAdmin = await RoleManager.RoleExistsAsync("Admin");
            if (!rolAdmin)
            {

                var roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

        }
    }
}
