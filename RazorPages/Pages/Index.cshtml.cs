using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using System.Text.Json;

namespace RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Libro> Libros { get; set; } = new();
        public List<string> Categorias { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string Query { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string SelectedCategoria { get; set; } = string.Empty;

        public UsuarioModel ObtenerUsuario()
{
    var usuarioJson = HttpContext.Session.GetString("usuario");

    if (string.IsNullOrEmpty(usuarioJson))
        return null;

    return JsonSerializer.Deserialize<UsuarioModel>(usuarioJson);
}


        public void OnGet()
        {
            CargarLibros();
            
        }

        private List<Libro> ObtenerLibros()
        {
            var ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/data/libros.json");
            var json = System.IO.File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Libro>>(json) ?? new List<Libro>();
        }

        private void CargarLibros()
        {
            var todosLosLibros = ObtenerLibros();

            // Filtrado por búsqueda
            Libros = string.IsNullOrEmpty(Query)
                ? todosLosLibros
                : todosLosLibros
                    .Where(l => l.Titulo.Contains(Query, StringComparison.OrdinalIgnoreCase)
                             || l.Autor.Contains(Query, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            // Filtrado por categoría
            if (!string.IsNullOrEmpty(SelectedCategoria))
            {
                Libros = Libros
                    .Where(l => l.Categoria.Equals(SelectedCategoria, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Todas las categorías únicas (para mostrar los botones)
            Categorias = todosLosLibros
                .Where(l => !string.IsNullOrWhiteSpace(l.Categoria))
                .Select(l => l.Categoria)
                .Distinct()
                .ToList();
        }

        public IActionResult OnPostAgregarCarrito(int id)
{
    var libro = ObtenerLibros().FirstOrDefault(l => l.Id == id);
    if (libro == null)
    {
        TempData["Mensaje"] = "Libro no encontrado";
        return RedirectToPage();
    }

    // Traer carrito
    var carritoJson = HttpContext.Session.GetString("carrito");
    var carrito = !string.IsNullOrEmpty(carritoJson)
        ? JsonSerializer.Deserialize<List<CarritoItem>>(carritoJson)
        : new List<CarritoItem>();

    // Buscar si ya existe
    var existente = carrito.FirstOrDefault(c => c.Id == libro.Id);
    if (existente != null)
    {
        existente.Cantidad++;
    }
    else
    {
        carrito.Add(new CarritoItem
        {
            Id = libro.Id,
            Titulo = libro.Titulo,
            Autor = libro.Autor,
            Descripcion = libro.Descripcion,
            Imagen = libro.Imagen,
            Precio = libro.Precio,
            Cantidad = 1
        });
    }

    // Guardar carrito
    HttpContext.Session.SetString("carrito", JsonSerializer.Serialize(carrito));
    TempData["Mensaje"] = $"'{libro.Titulo}' agregado al carrito";

    return RedirectToPage();
}
public int ObtenerCantidadCarrito()
{
    var carritoJson = HttpContext.Session.GetString("carrito");
    var carrito = !string.IsNullOrEmpty(carritoJson)
        ? JsonSerializer.Deserialize<List<CarritoItem>>(carritoJson)
        : new List<CarritoItem>();
    return carrito.Sum(c => c.Cantidad);
}


    }
}
