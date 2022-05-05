namespace Agenda
{
    public class Contato
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public int Telefone { get; set; }
        public string? Relacionamento { get; set; }
        public IList<Cliente> Clientes { get; set; } = new List<Cliente>();

    }
}
