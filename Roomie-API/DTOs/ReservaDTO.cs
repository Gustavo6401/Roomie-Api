using Roomie_API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Roomie_API.DTOs;

public class ReservaDTO
{        
    public int Id { get; set; }
    [Required]
    public DateTime DataInicio { get; set; }
    [Required]
    public DateTime DataTermino { get; set; }

    public Usuario? Usuario { get; set; }
    public int QuartoId { get; set; }
    public Quarto Quarto { get; set; } = null!;
}
