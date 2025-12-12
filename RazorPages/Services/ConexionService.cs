using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace RazorPages.Services
{
    public class ConexionService
    {
        private readonly IConfiguration _config;

        public ConexionService(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection ObtenerConexion()
        {
            string cadena = _config.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Cadena de conexión no encontrada.");
            return new MySqlConnection(cadena);
        }
    }
}
