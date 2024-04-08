namespace B2GNowCoding.Db.Interface
{
    public interface IGetEmployees
    {
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetEmployeeBySearch(string search);
    }
}
