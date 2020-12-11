using AdminApp.Domain.Models;
using System.Collections.Generic;

namespace AdminApp.Application.ViewModels
{
	public class EmployeeViewModel
	{

		public IEnumerable<Employee> Employees { get; set; }

	}
}
