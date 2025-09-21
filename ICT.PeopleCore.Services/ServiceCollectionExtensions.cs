using ICT.PeopleCore.Interface.Employee;
using ICT.PeopleCore.Services.EmployeeServices;
using Microsoft.Extensions.DependencyInjection;

namespace ICT.PeopleCore.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<IEmployee, EmployeeService>();

            return services;
        }
    }
}
