using ICT.PeopleCore.Entity.ApiServiceResponse;
using ICT.PeopleCore.Entity.ResponseEntity.Employee;

namespace ICT.PeopleCore.Interface.Employee
{
    public interface IEmployee
    {
        Task<ApiServiceResponse<IEnumerable<EmployeeReadEntity>>> GetEmployeesAsync();
    }
}
