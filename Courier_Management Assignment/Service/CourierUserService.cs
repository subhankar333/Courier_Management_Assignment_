using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courier_Management_Assignment.Model;
using Courier_Management_Assignment.Repository;
 

namespace Courier_Management_Assignment.Service
{
    internal class CourierUserService:ICourierUserService
    {
        readonly ICourierUserRepository _courierUserRepository;

        //Constructor
        public CourierUserService()
        {
            _courierUserRepository = new CourierUserRepository();
        }

        public void GetAllCouriers()
        {
            List<Courier> courierList = _courierUserRepository.GetAllCouriers();
            
            foreach (Courier item in courierList)
            {
                Console.WriteLine(item);
            }
        }

        public void placeOrder()
        {
            Courier courier = new Courier();

            Console.WriteLine("Enter courier id:");
            courier.CourierID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter sender name:");
            courier.Sender_Name = Console.ReadLine();

            Console.WriteLine("Enter sender address:");
            courier.Sender_Address = Console.ReadLine();

            Console.WriteLine("Enter receiver name:");
            courier.Receiver_Name = Console.ReadLine();

            Console.WriteLine("Enter receiver address:");
            courier.Receiver_Address = Console.ReadLine();

            Console.WriteLine("Enter weight:");
            courier.Weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter courier status:");
            courier.Status = Console.ReadLine();

            courier.Tracking_Number = Courier.getNextTrackingNo1();

            Console.WriteLine("Enter delivery date:");
            courier.Delivery_Date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter service id:");
            courier.ServiceId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee id:");
            courier.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter user id:");
            courier.UserId = int.Parse(Console.ReadLine());

           string trackNo =  _courierUserRepository.placeOrder(courier);
            Console.WriteLine(trackNo);
        }

        public void getOrderStatus()
        {

            Console.WriteLine("Enter tracking number");
            string trackNo = Console.ReadLine();

            Courier courier = _courierUserRepository.getOrderStatus(trackNo);
            if(courier != null)
            {
              Console.WriteLine($"CourierID:: {courier.CourierID}\t Sender_Name:: {courier.Sender_Name}\t Tracking_Number:: {courier.Tracking_Number}\t Status:: {courier.Status}");
            }

        }

        public void getAssignedOrder()
        {

            Console.WriteLine("Enter id of the employee: ");
            int empId = int.Parse(Console.ReadLine());

            List<Courier> courierList = _courierUserRepository.getAssignedOrder(empId);
            if(courierList != null)
            {
                foreach (var courier in courierList)
                {
                    Console.WriteLine($"CourierID:: {courier.CourierID}\t Status:: {courier.Status}");
                }
            }

        }


        public void getOrderById()
        {

            Console.WriteLine("Enter id of the Courier: ");
            int Id = int.Parse(Console.ReadLine());

            Courier courier = _courierUserRepository.getOrderById(Id);
            Console.WriteLine(courier);
        }

        public void updateOrder()
        {

            Console.WriteLine("Enter id of the Courier: ");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter address of receiver: ");
            string address = Console.ReadLine();

            bool updateStatus = _courierUserRepository.updateOrder(Id,address);
            if (updateStatus)
            {
                Console.WriteLine("Order updated successfully.");
            }
            else
            {
                Console.WriteLine("Order not updared.");
            }
        }
    }
}
