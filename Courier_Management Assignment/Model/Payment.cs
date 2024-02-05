
namespace Courier_Management_Assignment.Model
{
    internal class Payment
    {
        private int _paymentID;
        private int _CourierID;
        private int _amount;
        private string _paymentDate;

        // Getter and Setter
        public int PaymentId { get { return _paymentID; } set { _paymentID = value; } }
        public int CourierId { get { return _CourierID; } set { _CourierID = value; } }
        public int Amount { get { return _amount; } set { _amount = value; } }
        public string PaymentDate { get { return _paymentDate; } set { _paymentDate = value; } }

        // Constructors(Default and Parametrized)
        public Payment()
        {

        }

        public Payment(int paymentID, int courierID, int amount, string paymentDate)
        {
            _paymentID = paymentID;
            _CourierID = courierID;
            _amount = amount;
            _paymentDate = paymentDate;
        }

        // toString()
        public override string ToString()
        {
            return $"PaymentId:: {PaymentId}\t CourierId:: {CourierId}\t Amount:: {Amount}\t PaymentDate:: {PaymentDate}";
        }
    }
}
