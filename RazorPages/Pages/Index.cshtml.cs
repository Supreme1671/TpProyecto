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
                new librosModel { Id = 1, Titulo = "Piense y hágase rico", Autor = "Napoleon Hill",Anio = 1967, Precio = 3500, Imagen = "so.jpg"},
                new librosModel { Id = 2, Titulo = "El intercambio", Autor = "John Grishman", Anio = 1943, Imagen = "Elintercambio.jpg"},
                new librosModel { Id = 3, Titulo = "El arte de ser nosotros", Imagen = "Elarte.png", Autor = "Walter Riso", },
                new librosModel { Id = 4, Titulo = "Los ingenieros del caos" , Autor = "Jordi Borràs", Imagen = "1211.jpg"},
                new librosModel { Id = 5, Titulo = "Deja de ser tu" , Autor = "Joe Dispenza",Imagen = "ses.jpg"},
                new librosModel { Id = 6, Titulo = "Viaje a el centro de la tierra" , Autor = "Julio Verne", Imagen = "tierra.jpg"},
                new librosModel { Id = 7, Titulo = "GRAVITY FALLS DIARIO 3" , Autor = "Alex Hirsch", Imagen = "diario.jpg"},
                new librosModel { Id = 8, Titulo = "La niña del sombrero azul" , Autor = "Ana Alcolea", Imagen = "som.jpg"},
                new librosModel { Id = 9, Titulo = "EL HIJO DE NEPTUNO ( LOS HEROES DEL OLIMPO )" , Autor = "Rick Riordan", Imagen = "nepa.jpg"},
                new librosModel { Id = 10, Titulo = "AMANECER EN LA COSECHA ( LIBRO 5 DE LOS JUEGOS DEL HAMBRE )" , Autor = "Suzanne Collins", Imagen = "juegos.jpg"},

            };
        }
    }
    
}