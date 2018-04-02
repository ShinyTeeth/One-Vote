using Microsoft.EntityFrameworkCore;

namespace onevote.Models
{
    public class BallotContext : DbContext
    {
        public BallotContext(DbContextOptions<BallotContext> options)
                : base(options)
        {
        }

        public DbSet<Ballot> Ballot { get; set; }
    }
}