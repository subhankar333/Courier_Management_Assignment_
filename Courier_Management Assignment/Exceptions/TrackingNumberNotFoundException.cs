using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Management_Assignment.Exceptions
{
    internal class TrackingNumberNotFoundException:ApplicationException
    {
        public TrackingNumberNotFoundException()
        {

        }

        public TrackingNumberNotFoundException(string message) : base(message)
        {

        }
    }
}
