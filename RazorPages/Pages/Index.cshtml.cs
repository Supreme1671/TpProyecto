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
                new librosModel { Id = 1, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Anio = 1967, Descripcion = "Historia de la familia Buendía en el pueblo ficticio de Macondo.", Precio = 3500 , Imagen = "/wwwroot/img/mald.jpg" },
                new librosModel { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Descripcion = "Un cuento poético y filosófico sobre un pequeño príncipe que viaja por planetas.", Precio = 2800 },
                new librosModel { Id = 99, Titulo = "De prueba", Imagen = "https://via.placeholder.com/250x350.png?text=Libro+Prueba" }
                
            };
        }
    }
    
}