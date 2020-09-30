using Abp.Domain.Entities;

namespace docspider.Contatos
{
    public class Contato : Entity
    {
        public string Nome { get; set; }
        public long Telefone { get; set; }
    }
}
