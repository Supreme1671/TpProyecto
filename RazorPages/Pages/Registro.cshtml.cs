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
            if (_registroService.CorreoExiste(NuevoRegistro.Correo))
            {
                MensajeError = "El email ya está registrado.";
                return Page();
            }

            bool exito = _registroService.RegistrarUsuario(NuevoRegistro);
            if (exito)
            {
                MensajeExito = "¡Registro exitoso!";
                return RedirectToPage("/login");
            }
            else
            {
                MensajeError = "Error al registrar el usuario.";
                return Page();
            }
        }
    }
}
