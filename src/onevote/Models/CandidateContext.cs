using Microsoft.EntityFrameworkCore;

namespace onevote.Models
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions<CandidateContext> options)
                : base(options)
        {
        }

        public DbSet<Candidate> Candidate { get; set; }
    }
}