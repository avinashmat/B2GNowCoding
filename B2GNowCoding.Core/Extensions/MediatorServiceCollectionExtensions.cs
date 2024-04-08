using Microsoft.Extensions.DependencyInjection;

namespace B2GNowCoding.Core.Extensions
{
    public static class MediatorServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatorDependecies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(MediatorServiceCollectionExtensions).Assembly));
            return services;
        }
    }
}
