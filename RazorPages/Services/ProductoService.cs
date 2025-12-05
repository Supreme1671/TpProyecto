using MySql.Data.MySqlClient;
using System.Collections.Generic;
using RazorPages.Models;
public class ProductoService
{
    private readonly string _connectionString;

    public ProductoService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("MySqlConnection");
    }

    public List<string> ObtenerCategorias()
    {
        var categorias = new List<string>();

        using var con = new MySqlConnection(_connectionString);
        con.Open();

        using var cmd = new MySqlCommand("SELECT DISTINCT Categoria FROM Libros", con);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            categorias.Add(reader.GetString("Categoria"));
        }

        return categorias;
    }
}
