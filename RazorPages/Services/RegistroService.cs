using MySql.Data.MySqlClient;
using RazorPages.Models;
using Microsoft.Extensions.Configuration;

namespace RazorPages.Services
{
    public class RegistroService
    {
        private readonly string _connectionString;

        public RegistroService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        public bool CorreoExiste(string correo)
        {
            using var con = new MySqlConnection(_connectionString);
            con.Open();
            using var cmd = new MySqlCommand("SELECT COUNT(*) FROM Registro WHERE Correo = @correo", con);
            cmd.Parameters.AddWithValue("@correo", correo);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public bool ValidarLogin(string correo, string contrasena)
        {
            using var con = new MySqlConnection(_connectionString);
            con.Open();
            using var cmd = new MySqlCommand("SELECT COUNT(*) FROM Registro WHERE Correo = @correo AND Contrasena = @contrasena", con);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contrasena", contrasena);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public bool RegistrarUsuario(Registro usuario)
        {
            if (CorreoExiste(usuario.Correo)) return false;
            using var con = new MySqlConnection(_connectionString);
            con.Open();
            using var cmd = new MySqlCommand("INSERT INTO Registro (Correo, Contrasena, Nombre, Apellido) VALUES (@correo, @contrasena, @nombre, @apellido)", con);
            cmd.Parameters.AddWithValue("@correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
