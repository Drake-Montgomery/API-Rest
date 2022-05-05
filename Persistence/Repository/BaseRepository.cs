using Agenda.Persistence.Contexts;

namespace Agenda.Persistence.Repository
{
    public abstract class BaseRepository
    {
        protected readonly Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }
    }
}
