using AdminApp.Domain.Interfaces;
using AdminApp.Domain.Models;
using AdminApp.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace AdminApp.Infra.Data.Repository
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly AdminAppDbContext _context;

		public EmployeeRepository(AdminAppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Employee> GetEmployees() => _context.Employees;
		//{
		//	List<Employee> list = new List<Employee>();
		//	foreach (var employee in _context.Employees) list.Add(employee);
		//	return list;
		//}
	}
}
