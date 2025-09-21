using ICT.PeopleCore.Entity.ResponseEntity.Employee;
using ICT.PeopleCore.Repository.Interface.Employee;

namespace ICT.PeopleCore.Repository.Services.EmployeeRepository
{
    public class EmployeeRepositoryServices : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeReadEntity>> GetEmployeesAsync()
        {
            return new List<EmployeeReadEntity>
            {
                new EmployeeReadEntity { Id = 1, Name = "John Doe", Address = "Software Engineer" },
                new EmployeeReadEntity { Id = 2, Name = "Jane Smith", Address = "Project Manager" }
            };
        }
    }
}
