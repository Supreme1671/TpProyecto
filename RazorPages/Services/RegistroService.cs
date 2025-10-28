using MySql.Data.MySqlClient;
using RazorPages.Models;
using BCrypt.Net;

namespace RazorPages.Services
{
    public class RegistroService
    {
        private readonly string _connectionString;

        public RegistroService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        // ✅ NUEVO MÉTODO: Verifica si un correo ya está registrado
        public bool CorreoExiste(string correo)
{
    try
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();

        string sql = "SELECT COUNT(*) FROM Registro WHERE Correo = @Correo";
        using var cmd = new MySqlCommand(sql, connection);
        cmd.Parameters.AddWithValue("@Correo", correo);

        object result = cmd.ExecuteScalar();

        // Convertir correctamente el resultado (puede venir como int o long)
        int count = Convert.ToInt32(result);

        Console.WriteLine($"CorreoExiste('{correo}') = {count} registros encontrados");
        return count > 0;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al verificar correo: {ex.Message}");
        return false;
    }
}


        // MÉTODO PARA REGISTRAR UN USUARIO NUEVO
        public bool RegistrarUsuario(Registro registro)
{
    try
    {
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();

        string hash = BCrypt.Net.BCrypt.HashPassword(registro.Contrasena);

        string query = @"INSERT INTO Registro 
                        (Nombre, Apellido, Correo, Contrasena)
                        VALUES (@Nombre, @Apellido, @Correo, @Contrasena)";

        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Nombre", registro.Nombre);
        cmd.Parameters.AddWithValue("@Apellido", registro.Apellido);
        cmd.Parameters.AddWithValue("@Correo", registro.Correo);
        cmd.Parameters.AddWithValue("@Contrasena", hash);

        int filas = cmd.ExecuteNonQuery();
        Console.WriteLine($"Filas insertadas: {filas}");
        return filas > 0;
    }
    catch (MySql.Data.MySqlClient.MySqlException ex)
    {
        Console.WriteLine($"MySQL error: {ex.Number} - {ex.Message}");
        return false;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error general: {ex.Message}");
        return false;
    }
}


        // MÉTODO PARA VALIDAR LOGIN
        public bool ValidarLogin(string correo, string contrasena)
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();

                string sql = "SELECT Contrasena FROM Registro WHERE Correo = @Correo LIMIT 1";
                using var cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Correo", correo);

                var result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return false;

                string hashAlmacenado = result.ToString();

                bool esValida = BCrypt.Net.BCrypt.Verify(contrasena, hashAlmacenado);
                return esValida;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al validar login: {ex.Message}");
                return false;
            }
        }
    }
}
