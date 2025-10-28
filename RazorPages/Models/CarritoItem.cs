namespace RazorPages.Models
{
    public class CarritoItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public string Anio { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public decimal Precio { get; set; }
        public string Imagen { get; set; } = "";
        public int Cantidad { get; set; } = 1;
        
    }
}
