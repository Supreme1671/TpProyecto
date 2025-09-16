using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Collections.Generic;
using System.Linq;
namespace RazorPages.Pages
{
    public class librodetalleModel : PageModel
    {
        public Libro? Libro { get; set; }

        public IActionResult OnGet(int id)
        {
            var libros = new List<Libro>
            {
                new Libro { Id = 1, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Anio = 1967, Descripcion = "Historia de la familia Buendía en el pueblo ficticio de Macondo.", Precio = 3500, Imagen = "aaa.jpg"},
                new Libro { Id = 2, Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Anio = 1605, Descripcion = "Aventuras del ingenioso hidalgo Don Quijote y su escudero Sancho Panza.", Precio = 4200 },
                new Libro { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Descripcion = "Un cuento poético y filosófico sobre un pequeño príncipe que viaja por planetas.", Precio = 2800 }
            };

            Libro = libros.FirstOrDefault(l => l.Id == id);

            if (Libro == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
