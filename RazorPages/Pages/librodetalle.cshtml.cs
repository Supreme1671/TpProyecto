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
                new Libro { Id = 1, Titulo = "Piense y hágase rico", Autor = "Napoleon Hill",Anio = 1967, Descripcion = "Así de fácil: la riqueza y la realización personal están al alcance de todas aquellas personas que lo desean; basta simplemente con desvelar un secreto, el secreto del éxito. Esta nueva edición de este magnífico clásico está basada en la versión original del autor, y ha sido revisada y corregida ampliamente. Andrew Carnegie, Henry Ford, Theodore Roosevelt, Thomas Edison, Alexander Graham Bell y John D. Rockefeller, entre otros, son algunos de los entrevistados por Napoleon Hill para poder entender las entrañas de su éxito. Cualquiera que ponga en práctica sus principios y su filosofía, sin duda obtendrá todo aquello que desee en la vida.", Precio = 3500, Imagen = "so.jpg"},
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
