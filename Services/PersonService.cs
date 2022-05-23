using System;
using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.Pages;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;
using lata_przestępne_z_użytkownikiem.Data;
using System.Security.Claims;

namespace lata_przestępne_z_użytkownikiem.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        private readonly PeopleContext _peopleContext;
        public PersonService(IPersonRepository personRepo, PeopleContext peopleContext)
        {
            _personRepo = personRepo;
            _peopleContext = peopleContext;
        }
        public void AddEntry(PersonForListVM person)
        {
            string[] words = person.FullName.Split(' ');
            Person personDb = new()
            {
                Id = person.Id,
                FirstName = words[0],
                LastName = words[1],
                Year = person.Year,
                localDate = person.localDate
            };
            personDb.ActualTime();
            _peopleContext.Person.Add(personDb);
            _peopleContext.SaveChanges();
        }
        public ListPersonForListVM GetAllEntries()
        {
            var people = _personRepo.GetAllRecords();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                var pVM = new PersonForListVM()
                {
                    Id = person.Id,
                    FullName = person.FirstName + " " + person.LastName,
                    Year = person.Year,
                    localDate = person.localDate
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }
        public ListPersonForListVM GetEntriesFromToday()
        {
            var people = _personRepo.TodaysRecords();
            ListPersonForListVM result = new ListPersonForListVM();
            result.People = new List<PersonForListVM>();
            foreach (var person in people)
            {
                if (person?.localDate?.Date == DateTime.Now.Date)
                {
                    var pVM = new PersonForListVM()
                    {
                        Id = person.Id,
                        FullName = person.FirstName + " " + person.LastName,
                        Year = person.Year,
                        localDate = person.localDate
                    };
                    result.People.Add(pVM);
                }
            }
            result.Count = result.People.Count;
            return result;
        }

    }
}
