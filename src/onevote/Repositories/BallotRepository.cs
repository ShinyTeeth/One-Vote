using System;
using System.Collections.Generic;
using onevote.Models;

namespace onevote.Repositories
{
    public class BallotRepository : IBallotRepository
    {
        public Ballot GetByID(int id)
        {
            return new Ballot()
            {
                ID = 0,
                VotedA = true,
                VotedB = false,
                DateSubmitted = DateTime.Now
            };
        }
        public List<Ballot> GetAll()
        {
            List<Ballot> ballots = new List<Ballot>();
            return ballots;
        }
    }
}