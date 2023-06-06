using System.ComponentModel.DataAnnotations;

namespace Roomie_Client.Models
{
    public class ReservaViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataTermino { get; set; }

        public UsuarioViewModel? Usuario { get; set; }
        public int QuartoId { get; set; }
        public QuartoViewModel Quarto { get; set; } = null!;
    }
}
