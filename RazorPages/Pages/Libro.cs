using RazorPages.Models;
using RazorPages.Pages;
namespace RazorPages.Models
{
    public class Libro : librosModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
