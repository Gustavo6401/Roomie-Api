using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Roomie_API.Entities;

namespace Roomie_API.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }
    [MinLength(3)]
    [MaxLength(100)]
    [Required]
    public string? Nome { get; set; }
    [EmailAddress]
    [MaxLength(150)]
    [Required]
    public string? EMail { get; set; }
    [PasswordPropertyText]
    [MaxLength(100)]
    [Required]
    public string? Senha { get; set; }
    [MaxLength(30)]
    [Required]
    public string? Telefone { get; set; }
    [MaxLength(75)]
    [Required]
    public string? Cidade { get; set; }
    [MinLength(2)]
    [StringLength(2)]
    [Required]
    public string? UF { get; set; }
    [MaxLength(100)]
    [Required]
    public string? Rua { get; set; }
    [MaxLength(30)]
    [Required]
    public string? Bairro { get; set; }
    [StringLength(9)]
    [Required]
    public string? CEP { get; set; }
    [Required]
    public int Numero { get; set; }
    [MaxLength(20)]
    [Required]
    public string? Role { get; set; }
    [MaxLength(100)]
    [Required]
    public string? Universidade { get; set; }
    [MaxLength(50)]
    [Required]
    public string? Curso { get; set; }

    public IList<Quarto>? Quartos { get; set; }
    public IList<Reserva>? Reservas { get; set; }
}
