namespace EmployeesManagement.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName.Substring(0,1)}. {LastName}";
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Department { get; set; }

    }
}
