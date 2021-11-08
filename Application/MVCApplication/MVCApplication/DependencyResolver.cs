using Domain.Interfaces;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Services;

namespace MVCApplication
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection services)
        {
            //Services
            services.AddTransient<IClienteService, ClienteService>();

            //Repositories
            services.AddTransient<IClienteRepository, ClienteRepository>();
        }
    }
}
