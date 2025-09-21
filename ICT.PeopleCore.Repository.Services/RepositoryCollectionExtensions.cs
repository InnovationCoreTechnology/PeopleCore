using ICT.PeopleCore.Repository.Interface.Employee;
using ICT.PeopleCore.Repository.Services.EmployeeRepository;
using Microsoft.Extensions.DependencyInjection;

namespace ICT.PeopleCore.Repository.Services
{
    public static class RepositoryCollectionExtensions
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepositoryServices>();
            return services;
        }
    }
}
