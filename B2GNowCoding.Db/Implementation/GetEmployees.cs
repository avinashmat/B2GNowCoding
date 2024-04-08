 
using B2GNowCoding.Db.Interface;
 
namespace B2GNowCoding.Db.Implementation
{
    public class GetEmployees : IGetEmployees
    {
        private B2GNowCodingDbContext _dbContext;
        public GetEmployees(B2GNowCodingDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public  IEnumerable<Employee> GetAll()
        {
            return _dbContext.Employee.ToList();
        }
    }
}
