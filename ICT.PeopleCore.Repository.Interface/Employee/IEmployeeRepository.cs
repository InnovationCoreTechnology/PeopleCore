using ICT.PeopleCore.Entity.ResponseEntity.Employee;

namespace ICT.PeopleCore.Repository.Interface.Employee
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeReadEntity>> GetEmployeesAsync();
    }
}
