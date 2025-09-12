using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Collections.Generic;

namespace RazorPages.Pages
{
    public class librosModel : PageModel
    {
        public List<Libro> ListaLibros { get; set; } = new List<Libro>();

        public void OnGet()
        {
            ListaLibros = new List<Libro>
            {
                new Libro { Id = 1, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez", Anio = 1967, Descripcion = "Historia de la familia Buendía en el pueblo ficticio de Macondo.", Precio = 3500 },
                new Libro { Id = 2, Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Anio = 1605, Descripcion = "Aventuras del ingenioso hidalgo Don Quijote y su escudero Sancho Panza.", Precio = 4200 },
                new Libro { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Descripcion = "Un cuento poético y filosófico sobre un pequeño príncipe que viaja por planetas.", Precio = 2800 }
            };
        }
    }
}
