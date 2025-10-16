using RazorPages.Models;

namespace RazorPages.Services;

public interface IRegistroRepository
{
    IEnumerable<Registro> GetAll();
    Libro? GetById(int id);
    void Add(Registro registro);
    void Update(Registro registro);
    void Remove(int id);
}
