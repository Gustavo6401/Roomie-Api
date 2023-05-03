namespace Roomie_API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? EMail { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public int Numero { get; set; }
        public string? Role { get; set; }
        public string? Universidade { get; set; }
        public string? Curso { get; set; }

        public IList<Quarto>? Quartos { get; set; }
    }
}
