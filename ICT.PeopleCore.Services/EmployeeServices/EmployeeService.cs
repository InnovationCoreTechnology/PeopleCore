using ICT.PeopleCore.Entity.ApiServiceResponse;
using ICT.PeopleCore.Entity.ResponseEntity.Employee;
using ICT.PeopleCore.Interface.Employee;
using ICT.PeopleCore.Repository.Interface.Employee;

namespace ICT.PeopleCore.Services.EmployeeServices
{
    public class EmployeeService : IEmployee
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<ApiServiceResponse<EmployeeReadEntity>> GetEmployeeAsync(int id)
        {
            var employeeReadEntity = await _employeeRepository.GetEmployeeAsync(id);

            if (employeeReadEntity == null)
                return ApiServiceResponse<EmployeeReadEntity>.FailureResponse("0001", "Error");

            return ApiServiceResponse<EmployeeReadEntity>.SuccessResponse(employeeReadEntity,
                "0001", "Employees retrieved successfully");
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        public async Task<ApiServiceResponse<IEnumerable<EmployeeReadEntity>>> GetEmployeesAsync()
        {
            var employees = await _employeeRepository.GetEmployeesAsync();

            if (!employees.Any())
                return ApiServiceResponse<IEnumerable<EmployeeReadEntity>>.FailureResponse("0001", "Error");

            return ApiServiceResponse<IEnumerable<EmployeeReadEntity>>.SuccessResponse(employees,
                "0001", "Employees retrieved successfully");
        }
    }
}
