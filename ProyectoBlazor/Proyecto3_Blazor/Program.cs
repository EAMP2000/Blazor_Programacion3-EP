using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Proyecto3_Blazor.Data;
using Proyecto3_Blazor.Interfacez;
using Proyecto3_Blazor.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

MySQLConfiguracion cadenaConexion = new MySQLConfiguracion(builder.Configuration.GetConnectionString("MySQL"));
builder.Services.AddSingleton(cadenaConexion);

builder.Services.AddScoped<IUsuarioServicio, UsuarioServicios>(); //para inyectar los  permisos.

var app = builder.Build();

//Configure la canalización de solicitudes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // El valor predeterminado de HSTS es de 30 días. Es posible que desee cambiar esto para escenarios de producción, consulte https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
