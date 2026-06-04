using System.Diagnostics.Contracts;

namespace Employee_Blazor.Data
{
    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public  EmployeeDetails() { }
        public EmployeeDetails(int id, String firstName, String lastName, String email, long phone)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }


    }
}
