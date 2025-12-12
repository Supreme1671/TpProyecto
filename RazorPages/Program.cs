using MySql.Data.MySqlClient;
using RazorPages.Services;
using RazorPages.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;


var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios

builder.Services.AddRazorPages();
builder.Services.AddSession(); // Para poder usar HttpContext.Session

// Inyección de dependencias

builder.Services.AddSingleton<ConexionService>();

builder.Services.AddSingleton<ILibroRepository, InMemoryLibroRepository>();
builder.Services.AddScoped<RegistroService>();
builder.Services.AddScoped<LibroService>();
builder.Services.AddScoped<ProductoService>();


// Configuración de autenticación (opcional, si usás Google)
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie()
.AddGoogle(googleOptions =>
{
    googleOptions.ClientId = "TU_CLIENT_ID";
    googleOptions.ClientSecret = "TU_CLIENT_SECRET";
});

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Debe ir antes de UseAuthentication y UseAuthorization
app.UseAuthentication();
app.UseAuthorization();

// Mapear páginas Razor2
app.MapRazorPages();

app.Run();
