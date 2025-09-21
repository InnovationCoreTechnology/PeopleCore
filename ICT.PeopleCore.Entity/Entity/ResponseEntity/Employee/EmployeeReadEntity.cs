namespace ICT.PeopleCore.Entity.Entity.ResponseEntity.Employee
{
    public class EmployeeReadEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; } 
        public int DepartmentId { get; set; }
        public int RoleId { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string CreatedOn { get; set; }
        public int IsActive { get; set; } 
    }
}
