using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;

using Microsoft.EntityFrameworkCore;

namespace lata_przestępne_z_użytkownikiem.Data
{
    public class PeopleContext : DbContext
    {

        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; } = null!;
    }
}

