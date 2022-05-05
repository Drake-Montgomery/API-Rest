namespace Agenda.Repository
{
    public interface IContatoRepository
    {
        Task<IEnumerable<Contato>> ListAsync();
    }
}
