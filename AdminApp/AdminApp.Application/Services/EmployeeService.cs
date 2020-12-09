using AdminApp.Application.Interfaces;
using AdminApp.Application.ViewModels;
using AdminApp.Domain.Interfaces;

namespace AdminApp.Application.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public EmployeeViewModel GetEmployees()
		{
			return new EmployeeViewModel()
			{
				Employees = _employeeRepository.GetEmployees()
			};
		}
	}
}
