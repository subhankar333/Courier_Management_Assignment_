using Courier_Management_Assignment.Model;
using Courier_Management_Assignment.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Repository
{
    internal class CourierAdminRepository:ICourierAdminRepository
    {

        //sql connection class
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CourierAdminRepository()
        {
            sqlconnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public int addCourierStaff(int empId, string name, string contactNo)
        {
            Employee employee = new Employee();
            employee.EmployeeID = empId;
            employee.Name = name;
            employee.ContactNumber = contactNo;
            cmd.CommandText = "insert into Employee values(@EmployeeID,@Name,@Email,@Role,@ContactNumber,@Salary)";
            cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            cmd.Parameters.AddWithValue("@Role", DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactNumber", employee.ContactNumber);
            cmd.Parameters.AddWithValue("@Salary", DBNull.Value);
            
            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            int addUserStatus = cmd.ExecuteNonQuery();
            sqlconnection.Close();

            if(addUserStatus > 0)
            {
                Console.WriteLine("Courier staff added successfully");
            }
            else
            {
                Console.WriteLine("Courier staff not added");
            }

            return employee.EmployeeID;
        }
    }
}
