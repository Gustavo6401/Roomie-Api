namespace Roomie_API.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? EMail { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Role { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaAtividade { get; set; }
    }
}
