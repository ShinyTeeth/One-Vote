using Microsoft.EntityFrameworkCore;

namespace onevote.Models
{
    public class OnevoteContext : DbContext
    {
        public OnevoteContext(DbContextOptions<OnevoteContext> options)
                : base(options)
        {
        }

        public DbSet<Election> Elections { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ballot> Ballots { get; set; }
    }
}