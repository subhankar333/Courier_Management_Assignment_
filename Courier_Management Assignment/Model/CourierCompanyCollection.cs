using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Model
{
    internal class CourierCompanyCollection
    {
        public List<CourierCompany> courierCompanyList { get; set; }

        public CourierCompanyCollection()
        {

        }

        public CourierCompanyCollection(List<CourierCompany> _courierCompanyList)
        {
            courierCompanyList = _courierCompanyList;
        }
        
    }
}
