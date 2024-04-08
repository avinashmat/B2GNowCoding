using Microsoft.EntityFrameworkCore;
namespace B2GNowCoding.Db
{
    public class B2GNowCodingDbContext : DbContext
    {
        public B2GNowCodingDbContext(DbContextOptions<B2GNowCodingDbContext> option) : base(option)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        //public DbSet<EmployeePhone> EmployeePhones { get; set; }
        //public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
    }

}
