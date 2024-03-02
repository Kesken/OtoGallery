using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business;

public static class BusinessServiceRegistiration
{
	public static IServiceCollection AddBusinessServices(this IServiceCollection services)
	{

		services.AddMediatR(cfg =>
		{
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
		});

		return services;
	}
}
