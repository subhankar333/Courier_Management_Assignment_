
namespace Courier_Management_Assignment.Model
{
    internal class Employee
    {
        // Getter and Setter 
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }

        // Constructor
        public Employee()
        {

        }

        // toString() 
        public override string ToString()
        {
            return $"EmployeeId:: {EmployeeID}\t EmployeeName:: {Name}\t Email:: {Email}\t ContactNumber:: {ContactNumber}\t Role:: {Role}\t Salary:: {Salary}";
        }
    }
}
