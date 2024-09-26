using System;
using Bussiness.Services;
using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Bussiness;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureBussinessLayer(this IServiceCollection services)
    {
        services.ConfigureDataLayer();
        services.AddScoped<ProductosService>();
        services.AddScoped<UsuariosService>();

        return services;
    }
}
