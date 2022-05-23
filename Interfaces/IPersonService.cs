using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;
using lata_przestępne_z_użytkownikiem.Models;

namespace lata_przestępne_z_użytkownikiem.Interfaces
{
    public interface IPersonService
    {
        public void AddEntry(PersonForListVM person);
        ListPersonForListVM GetAllEntries();
        ListPersonForListVM GetEntriesFromToday();

    }
}
