using System;
using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public class BallotRepository : IBallotRepository
    {
        public Ballot GetByID(int id)
        {
            if (id == 0)
            {
                return new Ballot(0, DateTime.Now, true);
            }

            if (id == 1)
            {
                return new Ballot(1, DateTime.Now, true);
            }

            if (id == 2)
            {
                return new Ballot(2, DateTime.Now, true);
            }

            return null;
        }
        public List<Ballot> GetAll()
        {
            List<Ballot> ballots = new List<Ballot>();
            ballots.Add(GetByID(0));
            ballots.Add(GetByID(1));
            ballots.Add(GetByID(2));
            return ballots;
        }
    }
}