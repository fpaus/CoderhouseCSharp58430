using UI.ClientServices;
using UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<ProductosService>();
builder.Services.AddTransient<UsuariosService>();

builder.Services.AddHttpClient<UsuariosService>(
    client => client.BaseAddress = new Uri($"{builder.Configuration["ApiUrl"]}/api/Usuarios/")
    );

builder.Services.AddHttpClient<ProductosService>(
    client => client.BaseAddress = new Uri($"{builder.Configuration["ApiUrl"]}/api/Productos/")
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
