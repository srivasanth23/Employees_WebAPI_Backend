using Microsoft.EntityFrameworkCore;

namespace WebApiEmployee.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options) { }

        protected EmployeeContext() { }

        public DbSet<Employee>  employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
     }
}
