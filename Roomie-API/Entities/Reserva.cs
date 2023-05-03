namespace Roomie_API.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        public Usuario? Usuario { get; set; }
        public Quarto? Quarto { get; set; }
    }
}
