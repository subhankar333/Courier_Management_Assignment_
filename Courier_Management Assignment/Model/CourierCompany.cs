
namespace Courier_Management_Assignment.Model
{
    internal class CourierCompany
    {
        private string _companyName;
        private string _courierDetails;
        private string _employeeDetails;
        private string _locationDetails;

        // Getter and Setter
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }
        public string CourierDetails { get { return _courierDetails; } set { _courierDetails = value; } }
        public string EmployeeDetails { get { return _employeeDetails; } set { _employeeDetails = value; } }
        public string LocationDetails { get { return _locationDetails; } set { _locationDetails = value; } }

        // Constructors(Default and Parametrized)
        public CourierCompany()
        {

        }

        public CourierCompany(string companyName, string courierDetails, string employeeDetails, string locationDetails)
        {
            _companyName = companyName;
            _courierDetails= courierDetails;
            _employeeDetails= employeeDetails;
            _locationDetails= locationDetails;
        }

        // toString()
        public override string ToString()
        {
            return $"CompanyName:: {CompanyName}\t CourierDetails:: {CourierDetails}\t EmployeeDetails:: {EmployeeDetails}\t LocationDetails:: {LocationDetails}";
        }
    }
}
