using Microsoft.EntityFrameworkCore;

namespace WebApiEmployee.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options) { }

        protected EmployeeContext() { }

        public DbSet<Employee>  Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
     }
}
