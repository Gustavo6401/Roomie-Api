using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Roomie_API.Entities;

namespace Roomie_API.DTOs;

public class QuartoDTO
{
    public int Id { get; set; }
    [MinLength(3)]
    [MaxLength(100)]
    [Required]
    public string? Titulo { get; set; }
    [MinLength(3)]
    [MaxLength(1000)]
    [Required]
    public string? Descricao { get; set; }
    [Required]
    public decimal Preco { get; set; }
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
    [MaxLength(75)]
    [Required]
    public string? Cidade { get; set; }
    [MinLength(2)]
    [StringLength(2)]
    [Required]
    public string? UF { get; set; }
    [Required]
    public int NumeroDeQuartos { get; set; }
    [Required]
    public int NumeroDeBanheiros { get; set; }
    [MaxLength(20)]
    [Required]
    public string? Disponibilidade { get; set; }
    [MaxLength(20)]
    [Required]
    public string? Status { get; set; }

    [JsonIgnore]
    public Usuario? Usuario { get; set; }
    public int UsuarioId { get; set; }
    [JsonIgnore]
    public Reserva? Reserva { get; set; }
    [JsonIgnore]
    public IList<Foto>? Fotos { get; set; }
}
