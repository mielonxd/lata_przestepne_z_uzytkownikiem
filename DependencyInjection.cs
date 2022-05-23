using lata_przestępne_z_użytkownikiem.Interfaces;
using lata_przestępne_z_użytkownikiem.Pages;
using lata_przestępne_z_użytkownikiem.Repositories;
using lata_przestępne_z_użytkownikiem.Services;

namespace lata_przestępne_z_użytkownikiem
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddTransient<IPersonService,PersonService>();
            services.AddTransient<IPersonRepository,PersonRepository>();
            return services;
        }


    }
}
