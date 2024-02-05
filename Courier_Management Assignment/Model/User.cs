

namespace Courier_Management_Assignment.Model
{
    internal class User
    {
        private int _userID;
        private string _userName;
        private string _email;
        private string _password;
        private string _contactNumber;
        private string _address;

        // Getter and Setter
        public int UserId { get { return _userID; } set { _userID = value; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }
        public string  Address { get { return _address; } set { _address = value; } } 


        // Constructors(Default and Parametrized)
        public User()
        {

        }
        public User(int id, string name, string email, string password, string contactNumber, string address)
        {
            _userID = id;
            _userName = name;
             _email = email;
            _password = password;
            _contactNumber = contactNumber;
            _address = address;
        }

        // toString()
        public override string ToString()
        {
            return $"Id:: {UserId}\t Username:: {UserName}\t Email:: {Email}\t Password:: {Password} Contactnumber:: {ContactNumber}\t Address:: {Address}";
        }

    }
}
