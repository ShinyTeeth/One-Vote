using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public class ElectionRepository : IElectionRepository
    {
        public Election GetByID(int id)
        {
            return new Election()
            {
                ID = 0,
            };
        }
    }
}