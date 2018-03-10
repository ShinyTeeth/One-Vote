using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        public Candidate GetByID(int id)
        {
            return new Candidate("Alex", "Z.");
        }
    }
}