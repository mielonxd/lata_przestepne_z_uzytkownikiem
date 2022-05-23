#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lata_przestępne_z_użytkownikiem.Data;
using lata_przestępne_z_użytkownikiem.Models;
using Microsoft.AspNetCore.Identity;

namespace lata_przestępne_z_użytkownikiem.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly lata_przestępne_z_użytkownikiem.Data.PeopleContext _context;

        public CreateModel(lata_przestępne_z_użytkownikiem.Data.PeopleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Person.Add(Person);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
