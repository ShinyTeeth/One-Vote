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
                return new Ballot()
                {
                    ID = 0,
                    Election = new Election(),
                    VotedA = true,
                    VotedB = false,
                    DateSubmitted = DateTime.Now
                };
            }

            if (id == 1)
            {
                return new Ballot()
                {
                    ID = 1,
                    Election = new Election(),
                    VotedA = true,
                    VotedB = false,
                    DateSubmitted = DateTime.Now
                };
            }

            if (id == 2)
            {
                return new Ballot()
                {
                    ID = 2,
                    Election = new Election(),
                    VotedA = false,
                    VotedB = true,
                    DateSubmitted = DateTime.Now
                };
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