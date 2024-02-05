using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Repository
{
    internal interface ICourierAdminRepository
    {
        int addCourierStaff(int empId, string name, string contactNo);
    }
}
