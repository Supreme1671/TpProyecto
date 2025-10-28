using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.Pages
{
    public class registroModel : PageModel
    {
        private readonly RegistroService _registroService;

        [BindProperty]
        public Registro NuevoRegistro { get; set; } = new Registro();

        public string MensajeError { get; set; } = "";
        public string MensajeExito { get; set; } = "";

        public registroModel(RegistroService registroService)
        {
            _registroService = registroService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
{
    Console.WriteLine($"Intentando registrar: {NuevoRegistro.Correo}");

    // Verificar si el correo existe
    if (_registroService.CorreoExiste(NuevoRegistro.Correo))
    {
        Console.WriteLine("Correo ya existe, pero redirigiendo a la página principal con el registro completo.");
        // Aquí podés guardar el registro completo en TempData o en sesión si querés mostrarlo en la página principal
        TempData["Nombre"] = NuevoRegistro.Nombre;
        TempData["Apellido"] = NuevoRegistro.Apellido;
        TempData["Correo"] = NuevoRegistro.Correo;
        
        return RedirectToPage("/Index"); // Redirige a la página principal
    }

    // Registrar nuevo usuario
    bool exito = _registroService.RegistrarUsuario(NuevoRegistro);
    if (exito)
    {
        Console.WriteLine("Usuario registrado correctamente, redirigiendo a la página principal.");
        TempData["Nombre"] = NuevoRegistro.Nombre;
        TempData["Apellido"] = NuevoRegistro.Apellido;
        TempData["Correo"] = NuevoRegistro.Correo;

        return RedirectToPage("/Index"); // Redirige a la página principal
    }
    else
    {
        MensajeError = "Error al registrar el usuario.";
        Console.WriteLine("Error: no se pudo insertar en la base de datos.");
        return Page();
    }
}

        }
    }

