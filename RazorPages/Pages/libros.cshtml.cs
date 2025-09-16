using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Pages
{
    public class librosModel : PageModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }

        public string Imagen { get; set; }
        public List<Libro> ListaLibros { get; set; } = new List<Libro>();
        public void OnGet()
        {
            ListaLibros = new List<Libro>
            {
                new Libro { Id = 1, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Anio = 1967, Descripcion = "Historia de la familia Buendía en el pueblo ficticio de Macondo.", Precio = 3500, Imagen="~/img/1211.jpg"},
                new Libro { Id = 2, Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Anio = 1605, Descripcion = "Aventuras del ingenioso hidalgo Don Quijote y su escudero Sancho Panza.", Precio = 4200},
                new Libro { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Descripcion = "Un cuento poético y filosófico sobre un pequeño príncipe que viaja por planetas.", Precio = 2800 },
                new Libro { Id = 4, Titulo = "Amanecer en la cosecha(JUEGOS DEL HAMBRE 5)", Autor = "Suzanne Collins", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
                new Libro { Id = 5, Titulo = "Gravity Falls, Diario 3", Autor = "Alex Hirsch y Rob Renzetti", Anio = 2016, Descripcion = "Un diario lleno de secretos, dibujos y misterios sobre fenómenos paranormales y criaturas sobrenaturales en un pueblo extraño.", Precio = 24900 },
                new Libro { Id = 6, Titulo = "El arte de ser nosotros", Autor = "Inma Rubiales", Anio = 2023, Descripcion = "Dos personas muy diferentes conectan a través de internet, enfrentando sus miedos y encontrando una inesperada amistad.", Precio = 12699 },
                new Libro { Id = 7, Titulo = "El crimen de año nuevo", Autor = "Daniel Balmaceda", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
                new Libro { Id = 8, Titulo = "", Autor = "", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
                new Libro { Id = 9, Titulo = "", Autor = "", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
                new Libro { Id = 10, Titulo = "", Autor = "", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
                new Libro { Id = 11, Titulo = "", Autor = "", Anio = 2025, Descripcion = "narra los orígenes de Haymitch en los Juegos del Hambre y su lucha por sobrevivir en un evento especial del Capitolio.", Precio = 12699 },
            };
        }
    }
}
