using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<librosModel> Libros { get; set; } = new();

        public void OnGet()
        {
            Libros = new List<librosModel>
            {
                new librosModel { Id = 1, Titulo = "Piense y hágase rico", Autor = "Napoleon Hill",Anio = 1967, Descripcion = "Así de fácil: la riqueza y la realización personal están al alcance de todas aquellas personas que lo desean; basta simplemente con desvelar un secreto, el secreto del éxito.", Precio = 3500, Imagen = "so.jpg"},
                new librosModel { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Descripcion = "Un cuento poético y filosófico sobre un pequeño príncipe que viaja por planetas.", Precio = 2800, Imagen = "diario.jpg"},
                new librosModel { Id = 99, Titulo = "De prueba", Imagen = "esp.jpg"}
                
            };
        }
    }
    
}