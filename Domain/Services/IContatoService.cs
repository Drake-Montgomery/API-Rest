namespace Agenda.Domain.Services
{
    public interface IContatoService
    {
        Task<IEnumerable<Contato>> ListAsync();
    }
}
