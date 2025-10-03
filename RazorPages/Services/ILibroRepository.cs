using System.Collections.Generic;
using RazorPages.Models;

public interface ILibroRepository
{
    IEnumerable<Libro> GetAll();
    Libro? GetById(int id);
    void Add(Libro libro);
    void Update(Libro libro);
    void Remove(int id);
}