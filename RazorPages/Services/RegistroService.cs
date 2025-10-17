using MySql.Data.MySqlClient;
using RazorPages.Models;



namespace RazorPages.Services
{
    public class RegistroService
    {
        private readonly string _connectionString;

        public RegistroService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        public bool RegistrarUsuario(Registro registro)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Registro (Nombre, Apellido, Correo, Contrasena) VALUES (@Nombre, @Apellido, @Correo, @Contrasena)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", registro.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", registro.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", registro.Correo);
                    cmd.Parameters.AddWithValue("@Contrasena", registro.Contrasena);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool CorreoExiste(string correo)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Registro WHERE Correo = @Correo";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
