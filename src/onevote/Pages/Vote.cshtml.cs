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
            if (VotedFor == "CandidateA")
            {
                Ballot ballotA = new Ballot(_electionID, DateTime.Now, true);
                _db.Ballots.Add(ballotA);
            }
            else if (VotedFor == "CandidateB")
            {
                Ballot ballotB = new Ballot(_electionID, DateTime.Now, false);
                _db.Ballots.Add(ballotB);
            }
            else
            {
                return Page();
            }
            await _db.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
