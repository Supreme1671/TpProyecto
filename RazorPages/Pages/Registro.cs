using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Page
{
    public class Registro
    {
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
    }
}
