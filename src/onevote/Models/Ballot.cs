using System;

namespace onevote.Models
{
    public class Ballot
    {
        public int ID { get; set; }
        public Election Election { get; set; }
        public bool VotedA { get; set; }
        public bool VotedB { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}