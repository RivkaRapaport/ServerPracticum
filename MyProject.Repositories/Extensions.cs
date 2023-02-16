using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;


namespace MyProject.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {

            service.AddScoped<IHmoRepository, HmoRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IChildRepository, ChildRepository>();

            return service;
        }
    }
}
