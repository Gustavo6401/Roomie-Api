using System.ComponentModel.DataAnnotations;
using Roomie_API.Entities;

namespace Roomie_API.DTOs;

public class FotoDTO
{
    public int Id { get; set; }
    [Required]
    public DateTime DataHoraEnvio { get; set; }
    [MaxLength(75)]
    [Required]
    public string? NomeArquivo { get; set; }
    public Quarto? Quarto { get; set; }
}
