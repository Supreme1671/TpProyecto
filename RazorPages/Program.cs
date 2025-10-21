using MySql.Data.MySqlClient;
using System.Data;
using RazorPages.Services;
using RazorPages.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ILibroRepository, InMemoryLibroRepository>();
builder.Services.AddScoped<RegistroService>();
builder.Services.AddScoped<LibroService>();



builder.Services.AddRazorPages();



var app = builder.Build();

app.UseStaticFiles();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()

   .WithStaticAssets();
   app.MapGet("/", context => {
    context.Response.Redirect("/Registro");
    return Task.CompletedTask;
});


app.Run();
