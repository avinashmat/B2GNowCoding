using B2GNowCoding.Db;
using B2GNowCoding.Db.Implementation;
using B2GNowCoding.Db.Interface;

namespace B2GNowCoding.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGetEmployees, GetEmployees>();
            return services;
        }
    }
}
