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
            services.AddTransient<IContratoService, ContratoService>();

            //Repositories
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IContratoRepository, ContratoRepository>();
        }
    }
}
