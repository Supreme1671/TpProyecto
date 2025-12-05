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

        public void OnGet() { }

        public IActionResult OnPost()
{
    if (!ModelState.IsValid)
    {
        MensajeError = "Por favor completa todos los campos correctamente.";
        return Page();
    }

    if (_registroService.CorreoExiste(NuevoRegistro.Correo))
    {
        MensajeError = "El correo ya está registrado.";
        return Page();
    }

    bool exito = _registroService.RegistrarUsuario(NuevoRegistro);
    if (exito)
    {
        // Crear objeto del usuario para la sesión
        var usuario = new UsuarioModel
        {
            Nombre = NuevoRegistro.Nombre,
            Apellido = NuevoRegistro.Apellido,
            Correo = NuevoRegistro.Correo
        };

        // Guardarlo en sesión (ahora con la clave correcta)
        HttpContext.Session.SetString("usuario", System.Text.Json.JsonSerializer.Serialize(usuario));

        return RedirectToPage("/Index");
    }
    else
    {
        MensajeError = "Error al registrar el usuario.";
        return Page();
    }
}

    }
}
