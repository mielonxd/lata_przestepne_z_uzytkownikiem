using lata_przestępne_z_użytkownikiem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;
using lata_przestępne_z_użytkownikiem.Services;


namespace lata_przestępne_z_użytkownikiem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;

        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public ListPersonForListVM Records { get; set; } = null!;
        public void OnGet()
        {
            Records = _personService.GetEntriesFromToday();
        }
        public void OnPost()
        {

        }
    }
}