using MySql.Data.MySqlClient;
using System.Collections.Generic;
using RazorPages.Models;

namespace RazorPages.Services
{
    public class LibroService
    {
        private readonly string _connectionString;

        public LibroService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        public List<Libro> GetLibros()
        {
            List<Libro> libros = new List<Libro>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Libro";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        libros.Add(new Libro
                        {
                            Id = reader.GetInt32("Id"),
                            Titulo = reader.GetString("Titulo"),
                            Autor = reader.GetString("Autor"),
                            Descripcion = reader.GetString("Descripcion"),
                            Precio = reader.GetDecimal("Precio"),
                            Imagen = reader.GetString("Imagen"),
                            Categoria = reader.GetString("Categoria")
                        });
                    }
                }
            }

            return libros;
        }
    }
}
