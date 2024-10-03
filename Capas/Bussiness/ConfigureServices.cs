using System;
using Bussiness.Services;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bussiness;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureBussinessLayer(
        this IServiceCollection services,
        IConfiguration configuration
        )
    {
        services.ConfigureDataLayer(configuration);
        services.AddScoped<ProductosService>();
        services.AddScoped<UsuariosService>();

        return services;
    }
}
