namespace EmployeesManagement.Models
{
    public class UserActivity
    {
        public string CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
