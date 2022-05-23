#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lata_przestępne_z_użytkownikiem.Data;
using lata_przestępne_z_użytkownikiem.Models;

namespace lata_przestępne_z_użytkownikiem.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly lata_przestępne_z_użytkownikiem.Data.PeopleContext _context;

        public IndexModel(lata_przestępne_z_użytkownikiem.Data.PeopleContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
