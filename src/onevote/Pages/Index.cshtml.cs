using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using onevote.Models;
using onevote.Repositories;

namespace onevote.Pages
{
    public class IndexModel : PageModel
    {
        private IElectionRepository _electionRepo;
        public Election Election { get; set; }
        
        public IndexModel(IElectionRepository electionRepo)
        {
            _electionRepo = electionRepo;
        }
        public void OnGet()
        {
            Election = _electionRepo.GetByID(0);
        }
    }
}
