using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public Registro Registro { get; set; } = new Registro();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Acá podrías guardar los datos del registro
            return RedirectToPage("/Index");
        }
    }
}
