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
    public class DetailsModel : PageModel
    {
        private readonly lata_przestępne_z_użytkownikiem.Data.PeopleContext _context;

        public DetailsModel(lata_przestępne_z_użytkownikiem.Data.PeopleContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Person.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
