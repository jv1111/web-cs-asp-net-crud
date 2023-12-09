using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }//EMPLOYEES IS THE TABLE NAME
    }
}
