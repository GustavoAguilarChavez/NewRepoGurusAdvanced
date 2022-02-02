using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TecGurusAdvancedUAMCORE.Utils;
using TecGurusUAMCommon.Interfaces;
using TecGurusUAMCommon.Services;
using TecGurusUAMFactory.Factories;
using TecGurusUAMFactory.Interfaces;
using TecGurusUAMInfrastructure;

namespace TecGurusAdvancedUAMCORE.DependencyContainer
{
    public static class InjectionContainer
    {
        /// <summary>
        /// Registro de la inyeccion de dependencias 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services)
        {
            //Repositorio CRUD
            services.AddScoped(typeof(IEfRepository<>), typeof(EfRepository<>));

            //Services
            services.AddScoped<IGroupService, GroupService>();

            //Factories
            services.AddScoped<IGroupModelFactory, GroupModelFactory>();

            //Configuracion antigua de la version 8 para abajo
            //services.AddAutoMapper();
            // Auto Mapper Configurations nueva configuracion version 11
            //para especificar cual es tu clase donde tienes registradas las conversiones
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
            return services;
        }
    }
}
