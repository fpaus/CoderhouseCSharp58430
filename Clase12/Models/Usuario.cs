using System.ComponentModel.DataAnnotations;

namespace Clase12.Models;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(100)]
    public string Apellido { get; set; }

    [Required]
    [MaxLength(50)]
    public string NombreUsuario { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(8)]
    public string Contraseña { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; }
}
