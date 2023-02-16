
using Microsoft.Extensions.DependencyInjection;
using MyProject.Repositories;
using MyProject.Services.Interface;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IHmoService,HmoService>();
            services.AddScoped<IChildService, ChildService>();

            services.AddAutoMapper(typeof(Mapping));

            return services;
        }
    }
}
