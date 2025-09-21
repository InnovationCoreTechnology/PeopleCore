using ICT.PeopleCore.Entity.Entity.ResponseEntity.Employee;

namespace ICT.PeopleCore.InterFace
{
    public interface IEmployee
    {
        Task<EmployeeReadEntity> GetEmployeesAsync();
    }
}
