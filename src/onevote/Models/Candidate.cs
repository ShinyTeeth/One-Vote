using System;

namespace onevote.Models
{
    public class Candidate
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        { 
            get { return FirstName + " " + LastName; } 
            private set {} 
        } 
        public DateTime BirthDate { get; set; }

        public Candidate(string firstName, string lastName)
        {
            this.ID = 0;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = DateTime.Now;
        }
    }
}