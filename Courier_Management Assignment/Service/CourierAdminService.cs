using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courier_Management_Assignment.Model;
using Courier_Management_Assignment.Repository;

namespace Courier_Management_Assignment.Service
{
    internal class CourierAdminService:ICourierAdminService
    {
        readonly ICourierAdminRepository _courieradminrepository;

        //Constructor
        public CourierAdminService()
        {
            _courieradminrepository = new CourierAdminRepository();
        }

        public void addCourierStaff()
        {

            Console.WriteLine("Enter id of Employee");
            int empId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name of Employee");
            string name = Console.ReadLine();

            Console.WriteLine("Enter contact no of Employee");
            string contactNo = Console.ReadLine();

            int Id = _courieradminrepository.addCourierStaff(empId, name, contactNo);
            Console.WriteLine($"Id : {Id}");

        }

    }
}
