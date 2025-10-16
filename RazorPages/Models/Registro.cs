using System.ComponentModel.DataAnnotations;
namespace RazorPages.Models;

public class Registro
{
    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Formato de correo inválido")]
    [RegularExpression(".+@gmail\\.com", ErrorMessage = "Debe ser un correo de Gmail")]
    public string Correo { get; set; }
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [DataType(DataType.Password)]
    [StringLength(50, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 50 caracteres")]
    public string Contrasena { get; set; }
}
