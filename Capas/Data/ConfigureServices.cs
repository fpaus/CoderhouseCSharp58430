using System;
using Data.Context;
using Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureDataLayer(
        this IServiceCollection services,
        IConfiguration configuration
        )
    {
        services.AddDbContext<CoderhouseContext>(
            optionBuilder => {
                var connectionString = configuration.GetConnectionString("Coderhouse");
                optionBuilder.UseSqlServer(connectionString);
            }
        );
        services.AddScoped<ProductosDataAccess>();
        services.AddScoped<UsuariosDataAccess>();
        return services;
    }
}
