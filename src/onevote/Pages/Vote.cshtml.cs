using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using onevote.Models;

namespace onevote.Pages
{
    public class VoteModel : PageModel
    {
        private OnevoteContext _db;
        private int _electionID;
        public Election Election { get; set; }
        [BindProperty]
        public string VotedFor { get; set; }
        public VoteModel(OnevoteContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Election = _db.Elections.SingleOrDefault(e => e.ID == id);
            _electionID = id;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Ballot ballot = new Ballot();
            ballot.DateSubmitted = DateTime.Now;
            ballot.EID = _electionID;
            if (VotedFor == "CandidateA")
            {
                ballot.VotedA = true;
                ballot.VotedB = false;
            }
            else if (VotedFor == "CandidateB")
            {
                ballot.VotedA = false;
                ballot.VotedB = true;
            }
            else
            {
                return Page();
            }
            _db.Ballots.Add(ballot);
            await _db.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
