using Microsoft.EntityFrameworkCore;

namespace Agenda.Persistence.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contato> Contato { get; set; }
    }
}
