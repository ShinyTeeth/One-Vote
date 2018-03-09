using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public interface ICandidateRepository
    {
        Candidate GetByID(int id);
    }
}