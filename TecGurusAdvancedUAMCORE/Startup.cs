using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using TecGurusAdvancedUAMCORE.Data;
using TecGurusAdvancedUAMCORE.DependencyContainer;
using TecGurusAdvancedUAMCORE.MiddleWareIdentityConfig;
using TecGurusUAMCommon.Entities;

namespace TecGurusAdvancedUAMCORE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDbContext<DBContextUAM>(options =>
             options.UseSqlServer(
                 Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI();
            //.AddDefaultTokenProviders();

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.RegisterDependencyInjection();

            services.AddMvc();
            services.AddControllersWithViews();
        }

        //private static void MapTest1(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("Map Test1");
        //    });
        //}

        //private static void MapTest2(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("Map Test2");
        //    });
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger, IServiceProvider service)
        {
            #region estructura base
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (env.IsProduction() || env.IsEnvironment("DEMO"))
            {
                var envName = env.EnvironmentName;
                app.UseExceptionHandler("/Error");
            }

            //Crear middleware donde muestre el nombre de variable de ambiente en la pantalla

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            //Delegados
            //Use -> realizar alguna accion del actual middleware y puede invocar el siguiente middleware,
            //Map -> evaluar las rutas entrantes en la petición y si cumple con alguna de ellas ejecutar un
            //miiddleware,
            //run-> regresa una respuesta a la peticion mediante el middleware
            //"cortocircuitar el pipeline"

            app.UseAuthentication();
            app.UseAuthorization();
            #endregion

            #region MiddleWare Example1

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hola desde Middleware1 ");
            //    await next.Invoke();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync(" Hola desde Middleware2");
            //});

            #endregion

            #region Middleware Example2
            ////delegado Map
            //app.Map("/map1", MapTest1);
            //app.Map("/map2", MapTest2);
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("<b>Hola desde Map delegado</b>");
            //});

            #endregion

            #region Middleware Example3
            //app.UseCustomeMiddleWare(logger);
            #endregion

            #region MiddlewareIdentity
    //        app.UseIdentityMiddleWare(service).Wait();
            #endregion

            //app.Run(async (context) =>
            //{
            //    throw new Exception("Error");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

    }
}