using Clase12.Context;
using Clase12.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Clase12
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDbContext<CoderhouseDbContext>(
                options => options.UseSqlServer("Data Source=10.0.2.2;Initial Catalog=Coderhouse;User ID=sa;Password=Str0ngPassword;TrustServerCertificate=True")
            );

            builder.Services.AddScoped<ProductosDataAccess>();
            builder.Services.AddScoped<UsuariosDataAccess>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
