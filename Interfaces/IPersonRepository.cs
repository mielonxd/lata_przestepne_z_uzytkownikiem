using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;

namespace lata_przestępne_z_użytkownikiem.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllRecords();
        IQueryable<Person> TodaysRecords();

    }
}
