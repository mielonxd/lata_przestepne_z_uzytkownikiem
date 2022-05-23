using lata_przestępne_z_użytkownikiem.Data;
using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;

namespace lata_przestępne_z_użytkownikiem.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;
        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetAllRecords()
        {
            return _context.Person;

        }
        public IQueryable<Person> TodaysRecords()
        {
            return _context.Person;
        }
    }
}
