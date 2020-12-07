using System;
using System.Collections.Generic;
using System.Text;
using AdminApp.Domain.Models;

namespace AdminApp.Domain.Interfaces
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetEmployees();


	}
}
