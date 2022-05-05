using Agenda.Domain.Services;
using Agenda.Repository;
using System.Collections.Generic;

namespace Agenda.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            this._contatoRepository = contatoRepository;
        }
        public async Task<IEnumerable<Contato>> ListAsync()
        {
            return await _contatoRepository.ListAsync();
        }
    }
}
