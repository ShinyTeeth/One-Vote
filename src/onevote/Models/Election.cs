using System;

namespace onevote.Models
{
    public class Election
    {
        public int ID { get; set; }
        public Candidate CandidateA { get; set; }
        public Candidate CandidateB { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location{ get; set; }
    }
}