using lata_przestępne_z_użytkownikiem.ViewModels.Person;

namespace lata_przestępne_z_użytkownikiem.ViewModels
{
    public class ListPersonForListVM
    {
        public int Id { get; set; }
        public List<PersonForListVM> People { get; set; } = null!;
        public int Count { get; set; }
    }
}
