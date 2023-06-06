using System.ComponentModel.DataAnnotations.Schema;

namespace Roomie_API.Entities
{
    public class Quarto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public int Numero { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public int NumeroDeQuartos { get; set; }
        public int NumeroDeBanheiros { get; set; }
        public string? Disponibilidade { get; set; }
        public string? Status { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Reserva? Reserva { get; set; }
        public IList<Foto>? Fotos { get; set; }
    }
}
