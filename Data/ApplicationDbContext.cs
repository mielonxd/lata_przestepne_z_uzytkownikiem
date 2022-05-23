using lata_przestępne_z_użytkownikiem.Models;
using lata_przestępne_z_użytkownikiem.ViewModels;
using lata_przestępne_z_użytkownikiem.ViewModels.Person;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lata_przestępne_z_użytkownikiem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        
    }
}