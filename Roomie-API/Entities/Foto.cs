namespace Roomie_API.Entities
{
    public class Foto
    {
        public int Id { get; set; }
        public DateTime DataHoraEnvio { get; set; }
        public string? NomeArquivo { get; set; }
        public Quarto? Quarto { get; set; }
    }
}
