using ICT.PeopleCore.Entity.ResponseEntity.Employee;

namespace ICT.PeopleCore.Repository.Interface.Employee
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<EmployeeReadEntity>> GetEmployeesAsync();
        public Task<EmployeeReadEntity> GetEmployeeAsync(int id);
    }
}
