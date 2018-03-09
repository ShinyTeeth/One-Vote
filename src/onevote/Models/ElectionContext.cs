using Microsoft.EntityFrameworkCore;

namespace onevote.Models
{
    public class ElectionContext : DbContext
    {
        public ElectionContext(DbContextOptions<ElectionContext> options)
                : base(options)
        {
        }

        public DbSet<Election> Election { get; set; }
    }
}