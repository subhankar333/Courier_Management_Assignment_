using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Service
{
    internal interface ICourierUserService
    {
        void GetAllCouriers();

        public void placeOrder();
        void getOrderStatus();

        void getAssignedOrder();

        void getOrderById();

        void updateOrder();
    }
}
