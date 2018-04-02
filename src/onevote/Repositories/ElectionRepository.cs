using System;
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
                CandidateA = new Candidate("Alex", "Z."),
                CandidateB = new Candidate("Blake", "Y."),
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now,
                Location = "Anytown"
            };
        }
    }
}