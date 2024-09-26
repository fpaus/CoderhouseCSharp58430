using System;
using Data.Context;
using Data.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureDataLayer(this IServiceCollection services)
    {
        services.AddDbContext<CoderhouseContext>();
        services.AddScoped<ProductosDataAccess>();
        services.AddScoped<UsuariosDataAccess>();
        return services;
    }
}
