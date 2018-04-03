using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using onevote.Models;

namespace onevote.Pages
{
    public class IndexModel : PageModel
    {
        private OnevoteContext _db;
        public List<Election> Elections { get; set; }
        
        public IndexModel(OnevoteContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Elections = _db.Elections.ToList();
        }
    }
}
