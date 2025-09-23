using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Libro> Libros { get; set; } = new();
        public List<string> Categorias { get; set; } = new();
        public string Query { get; set; } = string.Empty;
        public string SelectedCategoria { get; set; } = string.Empty;

        public void OnGet(string query, string categoria)
        {
            Query = query ?? string.Empty;
            SelectedCategoria = categoria ?? string.Empty;
            var all = new List<Libro>
            {
                new Libro { Id = 1, Titulo = "Piense y hágase rico", Autor = "Napoleon Hill",Anio = 1967, Precio = 3500, Imagen = "so.jpg", Categoria="Autoayuda" },
                new Libro { Id = 2, Titulo = "El intercambio", Autor = "John Grishman", Anio = 1943, Imagen = "Elintercambio.jpg", Categoria="Novela"},
                new Libro { Id = 3, Titulo = "El arte de ser nosotros", Imagen = "Elarte.png", Autor = "Walter Riso", Anio = 2023, Precio = 12699, Categoria="Autoayuda" },
                new Libro { Id = 4, Titulo = "Los ingenieros del caos" , Autor = "Jordi Borràs", Imagen = "1211.jpg", Anio = 2024, Precio = 12699, Categoria="Novela" },
                new Libro { Id = 5, Titulo = "Deja de ser tu" , Autor = "Joe Dispenza",Imagen = "ses.jpg", Anio = 2024, Precio = 12699, Categoria="Autoayuda" },
                new Libro { Id = 6, Titulo = "Viaje a el centro de la tierra" , Autor = "Julio Verne", Imagen = "tierra.jpg", Anio = 1864, Precio = 12699, Categoria="Literatura" },
                new Libro { Id = 7, Titulo = "GRAVITY FALLS DIARIO 3" , Autor = "Alex Hirsch", Imagen = "diario.jpg", Anio = 2016, Precio = 24900, Categoria="Novela" },
                new Libro { Id = 8, Titulo = "La niña del sombrero azul" , Autor = "Ana Alcolea", Imagen = "som.jpg", Anio = 2024, Precio = 12699, Categoria="Literatura" },
                new Libro { Id = 9, Titulo = "EL HIJO DE NEPTUNO ( LOS HEROES DEL OLIMPO )" , Autor = "Rick Riordan", Imagen = "nepa.jpg"},
                new Libro { Id = 10, Titulo = "AMANECER EN LA COSECHA ( LIBRO 5 DE LOS JUEGOS DEL HAMBRE )" , Autor = "Suzanne Collins", Imagen = "juegos.jpg"},
                new Libro { Id = 11, Titulo = "Los gatos de fortuna", Autor = "Anny Duperey", Imagen = "gatoFortuna.jpg" },
                new Libro { Id = 12, Titulo = "El laberinto en llamas (Las pruebas de apolo libro 3)", Autor = "Rick Riordan", Imagen = "ñasss.jpg" },
                new Libro { Id = 13, Titulo = "Un reino de promesas malditas", Autor = "Lexi Ryan", Imagen = "mald.jpg" },
                new Libro { Id = 14, Titulo = "La espada de Kuromori", Autor = "Jason Rohan", Imagen = "esp.jpg" },
                new Libro { Id = 15, Titulo = "El veneno del poder", Autor = "Gabriela Cerruti", Imagen = "veneno.jpg" },
                new Libro { Id = 16, Titulo = "Elon Musk", Autor = "Walter Isaacson", Imagen = "elon.jpg" },
                new Libro { Id = 17, Titulo = "El crimen de año nuevo", Autor = "Daniel Balmaceda", Imagen = "hhhh.jpg" },
                new Libro { Id = 18, Titulo = "Alma de gato", Autor = "Ruth Berger", Imagen = "almaGatoo.png" },
                new Libro { Id = 19, Titulo = "Bajo la misma estrella", Autor = "John Green", Imagen = "mismaEstrella.jpg" },
                new Libro { Id = 20, Titulo = "Yo antes de ti", Autor = "Jojo Moyes", Imagen = "antesDeTi.jpg" }
            };
            
             Categorias = all.Select(l => l.Categoria)
                            .Where(c => !string.IsNullOrWhiteSpace(c))
                            .Distinct()
                            .OrderBy(c => c)
                            .ToList();

            // Filtro por búsqueda
            if (!string.IsNullOrWhiteSpace(Query))
            {
                all = all.Where(l => l.Titulo.Contains(Query, System.StringComparison.OrdinalIgnoreCase)
                                   || l.Autor.Contains(Query, System.StringComparison.OrdinalIgnoreCase)
                                   || (l.Descripcion != null && l.Descripcion.Contains(Query, System.StringComparison.OrdinalIgnoreCase)))
                         .ToList();
            }

            // Filtro por categoría
            if (!string.IsNullOrWhiteSpace(SelectedCategoria))
            {
                all = all.Where(l => l.Categoria == SelectedCategoria).ToList();
            }

            Libros = all;
        }
    }
    
}