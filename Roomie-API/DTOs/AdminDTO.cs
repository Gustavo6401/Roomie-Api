using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Roomie_API.DTOs;

public class AdminDTO
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
    [MaxLength(25)]
    [Required]
    public string? Role { get; set; }
    [Required]
    public DateTime DataCriacao { get; set; }
    [Required]
    public DateTime UltimaAtividade { get; set; }
}
