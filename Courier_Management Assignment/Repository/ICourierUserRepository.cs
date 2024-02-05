using Courier_Management_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Repository
{
    internal interface ICourierUserRepository
    {
        List<Courier> GetAllCouriers();
        string placeOrder(Courier courier);
        Courier getOrderStatus(string trackNo);
        List<Courier> getAssignedOrder(int empId);
        Courier getOrderById(int id);
        bool updateOrder(int Id, string address);
    }
}
