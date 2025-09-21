using ICT.PeopleCore.Entity.ResponseEntity.Employee;
using ICT.PeopleCore.Repository.Interface.Employee;

namespace ICT.PeopleCore.Repository.Services.EmployeeRepository
{
    public class EmployeeRepositoryServices : IEmployeeRepository
    {
        public async Task<EmployeeReadEntity> GetEmployeeAsync(int id)
        {
            var employee = new EmployeeReadEntity { Id = id, Name = "John Doe", Address = "Software Engineer" };
            return employee;
        }

        public async Task<IEnumerable<EmployeeReadEntity>> GetEmployeesAsync()
        {
            var result = new List<EmployeeReadEntity>
            {
                new EmployeeReadEntity { Id = 1, Name = "John Doe", Address = "Software Engineer" },
                new EmployeeReadEntity { Id = 2, Name = "Jane Smith", Address = "Project Manager" }
            };
            return result;
        }
    }
}
