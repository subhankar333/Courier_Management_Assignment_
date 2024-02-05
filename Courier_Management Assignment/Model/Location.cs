

namespace Courier_Management_Assignment.Model
{
    internal class Location
    {
        private int _locationID;
        private string _locationName;
        private string _address;

        // Getter and Setter 
        public int LocationId { get { return _locationID; } set { _locationID = value; } }
        public string LocationName { get { return _locationName; } set { _locationName = value; } }
        public string Adderss { get { return _address; } set { _address = value; } }

        // Constructors(Default and Parametrized)

        public Location()
        {

        }

        public Location(int locationID, string locationName, string address)
        {
            _locationID = locationID;
            _locationName = locationName;
            _address = address;
        }

        // toString()
        public override string ToString()
        {
            return $"LocationId:: {LocationId}\t LocationName:: {LocationName}\t Address:: {Adderss}";
        }

    }
}
