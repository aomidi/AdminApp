using AdminApp.Application.Interfaces;
using AdminApp.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AdminApp.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection service)
		{
			//Application Layer
			service.AddScoped<IEmployeeService, IEmployeeService>();

			//Infra Data Layer
			service.AddScoped<IEmployeeRepository, IEmployeeRepository>();
		}
	}
}
