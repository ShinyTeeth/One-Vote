using System;

namespace onevote.Models
{
    public class Ballot
    {
        public int ID { get; private set; }
        public Election Election { get; private set; }
        public int EID { get; private set; }
        public bool VotedA { get; private set; }
        public bool VotedB { get; private set; }
        public DateTime DateSubmitted { get; private set; }

        public Ballot(int electionID, DateTime dateSubmitted, bool votedA)
        {
            this.EID = electionID;
            this.DateSubmitted = dateSubmitted;
            this.VotedA = votedA;
            this.VotedB = !votedA;
        }
    }
}