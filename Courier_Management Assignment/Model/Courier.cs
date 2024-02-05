

using System.Globalization;
using System.Text;

namespace Courier_Management_Assignment.Model
{
    public class Courier
    {
       public static string trackNo = "TRA22";

        public int CourierID { get; set; }
        public string Sender_Name { get; set; }
        public string Sender_Address { get; set; }
        public string Receiver_Name { get; set; }
        public string Receiver_Address { get; set; }
        public decimal Weight { get; set; }
        public string Status { get; set; }
        public string Tracking_Number { get; set; }
        public DateTime Delivery_Date { get; set; }
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }
        public int UserId { get; set; }

        public Courier()
        {

        }
        public static string getNextTrackingNo1()
        {
            Random rnd = new Random();
            int num = rnd.Next(23, 100);

            trackNo = "TRA" + Convert.ToString(num);
            return trackNo;
        }



        // toString()    
        public override string ToString()
        {
            return $"CourierId:: {CourierID}\t SenderName:: {Sender_Name}\t SenderAddress:: {Sender_Address}\t ReceiverName:: {Receiver_Name} ReceiverAddress:: {Receiver_Address}\t Weight:: {Weight}\t Status:: {Status}\t TrackingNumber:: {Tracking_Number}\t DeliveryDate:: {Delivery_Date}";
        }
    }
}
