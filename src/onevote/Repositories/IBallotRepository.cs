using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public interface IBallotRepository
    {
        Ballot GetByID(int id);
        List<Ballot> GetAll();
    }
}