using Core.Repositories.Abstracts;
using Core.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistiration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            return services;
        }
    }
}
