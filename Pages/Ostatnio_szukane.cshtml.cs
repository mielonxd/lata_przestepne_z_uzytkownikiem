using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.Data;
using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace lata_przestępne_z_użytkownikiem.Pages
{
    [Authorize]
    public class Ostatnio_szukaneModel : PageModel
    {
        private readonly ILogger<Ostatnio_szukaneModel> _logger;
        private readonly IPersonService _personService;
        public ListPersonForListVM Records { get; set; }
        public Ostatnio_szukaneModel(ILogger<Ostatnio_szukaneModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public void OnGet()
        {
            Records = _personService.GetAllEntries();
        }
    }
}
