using System;
using System.Collections.Generic;
using System.Text;
using AdminApp.Application.ViewModels;

namespace AdminApp.Application.Interfaces
{
	 public interface IEmployeeService
	 {
		 EmployeeViewModel GetEmployees();
	 }
}
