using AdminApp.Application.Interfaces;
using AdminApp.Application.Services;
using AdminApp.Domain.Interfaces;
using AdminApp.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AdminApp.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection service)
		{

			//Infra Data Layer
			service.AddScoped<IEmployeeRepository, EmployeeRepository>();

			//Application Layer
			service.AddScoped<IEmployeeService, EmployeeService>();

		}
	}
}
