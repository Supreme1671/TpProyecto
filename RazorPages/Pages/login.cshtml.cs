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
            bool existe = _registroService.CorreoExiste(Usuario.Correo);
            if (!existe)
            {
                MensajeError = "Correo no encontrado.";
                return Page();
            }

            // TODO: acá podrías validar contraseña real si lo implementás
            return RedirectToPage("/Index");
        }
    }
}
