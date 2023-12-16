using Microsoft.EntityFrameworkCore;

namespace EmpApp.Models
{
	public class EmployeeDb:DbContext
	{
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDb(DbContextOptions options):base(options)
        {
            
        }
    }
}
