using AdminApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.Infra.Data.Context
{
	public class AdminAppDbContext:DbContext
	{
		public AdminAppDbContext(DbContextOptions<AdminAppDbContext> options):base(options)
		{
			
		}

		public DbSet<Employee> Employees { get; set; }

	}
}
