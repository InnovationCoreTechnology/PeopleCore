using Microsoft.Extensions.DependencyInjection;

namespace ICT.PeopleCore.Helper
{
    public static class HelperCollectionExtensions
    {
        public static IServiceCollection AddHelperLayer(this IServiceCollection services)
        {
            //services.AddSingleton<IDateTimeHelper, DateTimeHelper>();
            // Add more helpers here

            return services;
        }
    }
}
