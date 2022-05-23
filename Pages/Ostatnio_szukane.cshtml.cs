using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lata_przestêpne_z_u¿ytkownikiem.Models;
using lata_przestêpne_z_u¿ytkownikiem.Data;
using lata_przestêpne_z_u¿ytkownikiem.Interfaces;
using lata_przestêpne_z_u¿ytkownikiem.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace lata_przestêpne_z_u¿ytkownikiem.Pages
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
