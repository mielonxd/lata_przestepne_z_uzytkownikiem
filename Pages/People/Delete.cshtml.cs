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
using Microsoft.AspNetCore.Identity;

namespace lata_przestępne_z_użytkownikiem.Pages.People
{
    public class DeleteModel : PageModel
    {
        private readonly lata_przestępne_z_użytkownikiem.Data.PeopleContext _context;

        public DeleteModel(lata_przestępne_z_użytkownikiem.Data.PeopleContext context)
        {
            _context = context;
        }
        [BindProperty]
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
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Person = await _context.Person.FindAsync(id);
            //nie działa :(
            //CreateModel create = new CreateModel(_context);
            // if (Person != null && User.Identity.Name == create.User.Identity.Name
            if (Person != null);
            {
                _context.Person.Remove(Person);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
