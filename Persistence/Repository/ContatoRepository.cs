using Agenda.Persistence.Contexts;
using Agenda.Repository;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Persistence.Repository
{
    public class ContatoRepository : BaseRepository, IContatoRepository
    {
        public ContatoRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Contato>> ListAsync()
        {
            return await _context.Contato.ToListAsync();
        }
    }
}
