using lata_przestępne_z_użytkownikiem.Data;
using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lata_przestępne_z_użytkownikiem.Pages
{
    public class AddPersonModel : PageModel
    {
        private readonly ILogger<AddPersonModel> _logger;
        private readonly PeopleContext _context;

        private readonly IPersonService _personService;
        public ListPersonForListVM Records { get; set; }

        [BindProperty]
        public PersonForListVM personVM { get; set; } = null!;

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; } = null!;
        public AddPersonModel(ILogger<AddPersonModel> logger, PeopleContext context, IPersonService personService)
        {
            _logger = logger;
            _context = context;
            _personService = personService;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";

            }
        }
        public void OnPost()
        {
            ViewData["check"] = personVM.check();
            _personService.AddEntry(personVM);
        }
    }
}
