using System.Collections.Generic;
using System.Linq;
using RazorPages.Models;

public class InMemoryLibroRepository : ILibroRepository
{
    private readonly List<Libro> _libros;

    public InMemoryLibroRepository()
    {
        _libros = new List<Libro> {
            new Libro { Id = 1, Titulo = "Cien Años de Soledad", Autor = "G. García Márquez", Precio = 3500, Imagen = "1211.jpg", Categoria="Clásicos" },
            // ... completar con los demás
        };
    }

    public IEnumerable<Libro> GetAll() => _libros;
    public Libro? GetById(int id) => _libros.FirstOrDefault(l => l.Id == id);
    public void Add(Libro libro) {
        libro.Id = _libros.Any() ? _libros.Max(l => l.Id) + 1 : 1;
        _libros.Add(libro);
    }
    public void Update(Libro libro) {
        var idx = _libros.FindIndex(l => l.Id == libro.Id);
        if (idx >= 0) _libros[idx] = libro;
    }
    public void Remove(int id) => _libros.RemoveAll(l => l.Id == id);
}
