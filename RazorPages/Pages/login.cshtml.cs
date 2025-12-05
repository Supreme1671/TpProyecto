using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.Pages
{
    public class LoginModel : PageModel
    {
        private readonly RegistroService _registroService;

        [BindProperty]
        public Registro Usuario { get; set; } = new Registro();

        public string MensajeError { get; set; } = "";

        public LoginModel(RegistroService registroService)
        {
            _registroService = registroService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!_registroService.CorreoExiste(Usuario.Correo))
            {
                MensajeError = "Correo no encontrado.";
                return Page();
            }

            bool valido = _registroService.ValidarLogin(Usuario.Correo, Usuario.Contrasena);
            if (!valido)
            {
                MensajeError = "Contraseña incorrecta.";
                return Page();
            }

            // Guardamos el nombre o correo en sesión
            HttpContext.Session.SetString("UsuarioLogueado", Usuario.Nombre ?? Usuario.Correo);

            return RedirectToPage("/Index");
        }

    }
}
