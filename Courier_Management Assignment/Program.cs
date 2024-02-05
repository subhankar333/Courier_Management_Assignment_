using Courier_Management_Assignment.Model;
using Courier_Management_Assignment.Repository;
using Courier_Management_Assignment.Service;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Courier_Management_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task1 problems */

            #region Qn-1
            //Console.WriteLine("Enter the current status of the Order : ");
            //string orderStatus;
            //orderStatus = Console.ReadLine();

            //if(orderStatus == "Delivered")
            //{
            //    Console.WriteLine("The order is delivered");
            //}
            //else if(orderStatus == "Processing")
            //{
            //    Console.WriteLine("The order is on it's way");
            //}
            //else if(orderStatus == "Cancelled")
            //{
            //    Console.WriteLine("The order is cancelled");
            //}
            #endregion

            #region Qn-2
            //Console.WriteLine("Enter weight of the parcel : ");
            //int Weight = Convert.ToInt32(Console.ReadLine());

            //switch(Weight)
            //{
            //    case (100):
            //        Console.WriteLine("Light weighted");
            //        break;
            //    case (200):
            //        Console.WriteLine("Medium weighted");
            //        break;
            //    default:
            //        Console.WriteLine("Heavy weighted");
            //        break;
            //}
            #endregion

            #region Qn-3
            //Console.WriteLine("Welcome to the System :---> ");
            //string empName = "Rakhim";
            //string empPass = "1234";

            //string custName = "Cornwell";
            //string custPass = "5678";

            //Console.WriteLine("Press the following keys to get ahead :");
            //Console.WriteLine("1 --> for Employee");
            //Console.WriteLine("2 --> for Customer");


            //int key = Convert.ToInt32(Console.ReadLine());

            //if(key == 1)
            //{
            //    Console.WriteLine("Welcome to the Employee System : \n");
            //    start:
            //    Console.WriteLine("Press the following keys to continue : \n");

            //    Console.WriteLine("1 --> for Registration");
            //    Console.WriteLine("2 --> for Login");
            //    Console.WriteLine("3 --> for Logout");


            //    int empKey = Convert.ToInt32(Console.ReadLine());

            //    if (empKey == 1)
            //    {
            //        Console.WriteLine("Registering user....");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        Console.WriteLine($"You have successfully registered, {name}");
            //        goto start;

            //    }
            //    else if(empKey == 2)
            //    {
            //        Console.WriteLine("User Login....");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        int tryCount = 0;

            //        if(empName == name && empPass == password)
            //        {
            //            Console.WriteLine($"Welcome {name},continue exploring our system \n");
            //            goto start;
            //        }
            //        else
            //        {
            //            if(tryCount < 3)
            //            {
            //                Console.WriteLine("Please try entering valid username or password");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your limit is over , please try again after 24 hours \n");
            //            }

            //            goto start;
            //        }
            //    }
            //    else if(empKey == 3)
            //    {
            //        Console.WriteLine("You have successfully logged out \n");

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Welcome to the Customer System :");
            //start:
            //    Console.WriteLine("Press the following keys to continue : \n");

            //    Console.WriteLine("1 --> for Registration");
            //    Console.WriteLine("2 --> for Login");
            //    Console.WriteLine("3 --> for Logout");
            //    Console.WriteLine("\n");

            //    int custKey = Convert.ToInt32(Console.ReadLine());

            //    if (custKey == 1)
            //    {
            //        Console.WriteLine("Registering user.... \n");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        Console.WriteLine($"You have successfully registered, {name}");
            //        goto start;

            //    }
            //    else if (custKey == 2)
            //    {
            //        Console.WriteLine("User Login.... \n");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        int tryCount = 0;

            //        if (custName == name && custPass == password)
            //        {
            //            Console.WriteLine($"Welcome {name},continue exploring our system \n");
            //            goto start;
            //        }
            //        else
            //        {
            //            if (tryCount < 3)
            //            {
            //                Console.WriteLine("Please try entering valid username or password \n");
            //                goto start;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your limit is over , please try again after 24 hours \n");
            //            }
            //        }
            //    }
            //    else if (custKey == 3)
            //    {
            //        Console.WriteLine("You have successfully logged out \n");

            //    }
            //}
            #endregion

            /* Task2 problems */

            #region Qn-4
            //int n = 4;

            //for(int i=0;i<n;i++)
            //{
            //    Console.WriteLine("Enter weight of the item :");
            //    int Weight = Convert.ToInt32(Console.ReadLine());
            //    if (Weight >= 20 && Weight < 50)
            //    {
            //        Console.WriteLine("Shipment 1 will be used");
            //    }
            //    else if (Weight >= 50 && Weight < 100)
            //    {
            //        Console.WriteLine("Shipment 2 will be used");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Shipment 3 will be used");
            //    }
            //}
            #endregion

            #region Qn-5

            //string[,] orders = new string[3,3]
            //{
            //    {"Fan", "Android", "Trimmer"},
            //    {"TV", "Laptop", "Hammer"},
            //    {"Headphones", "USB Cable", "Charger Adapter"}
            //};

            //Console.WriteLine("Enter customerId of the Customer : ");
            //int ID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The orders of the customer with id-{ID} are:");
            //for(int i=0;i<orders.GetLength(1);i++)
            //{
            //    Console.WriteLine($"{orders[ID-1,i]},");
            //}
            #endregion

            #region Qn-6
            //string[] locations = { "Kolkata", "Delhi", "Mumbai", "Gurgaon", "Chennai" };
            //int n = locations.Length;

            // Console.WriteLine("Real time location of the parcel is :")

            //string currLocation = locations[0];
            //Console.WriteLine($"Source location : {currLocation}");
            //int i = 1;

            //while(currLocation != "Chennai")
            //{
            //    Console.WriteLine($"Current Location : {currLocation}");
            //    currLocation = locations[i];
            //    i++;
            //}
            //Console.WriteLine($"Destination location : {currLocation}");
            #endregion


            /* Task3 probelms */

            #region Qn-7
            //string[] track = new string[5] {"Chennai","Madurai","Delhi","Noida","Kanpur"};

            //Console.WriteLine("Enter product id :");
            //int ID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Tracking history of the parcel with id-{ID} is :");
            //foreach(var items in track)
            //{
            //    Console.WriteLine($"--> {items}");
            //}
            #endregion

            #region Qn-8
            //string[] courier = {"Blue Dart", "Ecom", "DTDC", "FedEx", "Delhivery", "Express"};

            //Console.WriteLine("Enter distance of destination(KM) :");
            //int destDistance = int.Parse(Console.ReadLine());

            //if(destDistance < 50)
            //{
            //    Console.WriteLine($"Assigned courier will be : {courier[destDistance/10]}");
            //}
            //else
            //{
            //    Console.WriteLine($"Assigned courier will be : {courier[5]}");
            //}
            #endregion


            /* Task4 problems */

            #region Qn-9
            //string[,] trackStatus = new string[3, 2]
            //{
            //    {"1A","Parcel in transit"},
            //    {"2B","Parcel out for delivery"},
            //    {"3C","Parcel delivered"}
            //};

            //Console.WriteLine("Enter Tracking id of parcel : ");
            //string trackId = Console.ReadLine();

            //if (trackId == "1A")
            //{
            //    Console.WriteLine($"Status of parcel : {trackStatus[0, 1]}");
            //}
            //else if (trackId == "2B")
            //{
            //    Console.WriteLine($"Status of parcel : {trackStatus[1, 1]}");
            //}
            //else if (trackId == "3C")
            //{
            //    Console.WriteLine($"Status of parcel : {trackStatus[2, 1]}");
            //}
            #endregion

            #region Qn-10
            /*static bool ValidateCustData(string custData, string details)
            {
                switch (custData)
                {
                    case ("Name"):
                        return ValidateName(details);
                    case ("Address"):
                        return ValidateAddress(details);
                    case ("Phone"):
                        return ValidatePhone(details);
                    default:
                        Console.WriteLine("Data provided is invalid");
                        return false;
                }
            }

            static bool ValidateName(string Name)
            {
                return Regex.IsMatch(Name, "^[A-Za-z ]+$");
            }

            static bool ValidateAddress(string Address)
            {
                return Regex.IsMatch(Address, "^[A-Za-z0-9 ]+$");
            }

            static bool ValidatePhone(string Phone)
            {
                return Regex.IsMatch(Phone, @"^\d{3}-\d{3}-\d{4}$");
            }

            Console.WriteLine("Enter name of customer:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter address of customer:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter phone number of customer:");
            string phoneNo = Console.ReadLine();

            if (ValidateCustData("Name", name))
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Name is not valid");
            }
            if (ValidateCustData("Address", address))
            {
                Console.WriteLine("Address is valid");
            }
            else
            {
                Console.WriteLine("Address is not valid");
            }
            if (ValidateCustData("Phone", phoneNo))
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Phone number is not valid");
            } */
            #endregion

            #region Qn-11
            /* static void DataFormatter(string street,string state, string city, string zipCode)
            {
                // Capitalizing the first letter of each word
                street = char.ToUpper(street[0]) + street.Substring(1);
                state = char.ToUpper(state[0]) + state.Substring(1);
                city = char.ToUpper(city[0]) + city.Substring(1);

                // Formatting Zip Code
                if(Regex.IsMatch(zipCode,@"^\d{6}$"))
                {
                    Console.WriteLine("Zip Code is formatted");
                }
                else
                {
                    Console.WriteLine("Try entering valid Zip Code");
                }

                Console.WriteLine($"Street : {street} State : {state} City : {city}");
            }

            Console.WriteLine("Enter name of street");
            string street = Console.ReadLine();

            Console.WriteLine("Enter name of state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter name of city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter zip code");
            string zipCode = Console.ReadLine();

            DataFormatter(street,state,city,zipCode); */
            #endregion

            #region Qn-12
            /* string[,] details = new string[4, 2]
            {
                {"Name", "Raman Raghav"},
                {"Order Number", "12"},
                {"Delivery Address", "Patna"},
                { "Order date", "2024-02-07"}
            }; 

            Console.WriteLine($"Hello {details[0, 1]}, hope this message finds you well ! Your order having OrderNumber-{details[1, 1]} will arrive {details[2, 1]} on {details[2, 1]}");
            */
            #endregion

            #region Qn-13
            /* Console.WriteLine("Enter Source address:");
            string source = Console.ReadLine();

            Console.WriteLine("Enter Destination address:");
            string destination = Console.ReadLine();

            Console.WriteLine("Enter total distance:");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter weight of courier:");
            int weight = int.Parse(Console.ReadLine());

            if(distance <= 200 && weight <= 100)
            {
                Console.WriteLine($"Total shipping Cost : {(weight / distance) * 100} ");
            }
            else if (distance <= 200 && weight > 100)
            {
                Console.WriteLine($"Total shipping Cost : {(weight / distance) * 150} ");
            }
            else if (distance > 200 && weight <= 100)
            {
                Console.WriteLine($"Total shipping Cost : {(weight / distance) * 200} ");
            }
            else if (distance > 200 && weight > 100)
            {
                Console.WriteLine($"Total shipping Cost : {(weight / distance) * 250} ");
            } */
            #endregion

            #region Qn-14
            /*static bool checkPassword(string password)
            {
                return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$");
            }

            Console.WriteLine("Enter password :");
            string password = Console.ReadLine();

            bool isOkay = checkPassword(password);
            if(isOkay)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is not valid");
            }*/
            #endregion


            #region Qn-15
            /* string[] locations = new string[5] { "Kolkata", "Chennai", "Delhi", "Jharkhand", "Rajasthan" };
            Console.WriteLine("Enter address you want to check for:");
            string input_location = Console.ReadLine(); 

            foreach (string item in locations)
            {
                if(item.Equals(input_location))
                {
                    Console.WriteLine($"similar address is present :- {item}");
                }
            } */
            #endregion


            // Task-6
            #region Service methods
            /*Console.WriteLine("Press key to go ahead..");
            Console.WriteLine("1 --> CourierUserService");
            Console.WriteLine("2 --> CourierAdminService");
            int key = int.Parse(Console.ReadLine());

            switch(key)
            {
                case 1:
                    CourierUserImplement();
                    break;
                case 2:
                    CourierAdminImplement();
                    break;
                default:
                    Console.WriteLine("Enter a valid key.");
                    break;

            }

            static void CourierUserImplement()
            {
                Console.WriteLine("Welcome to CourierUserService, Press key to go ahead..");
                Console.WriteLine("1 --> PlaceOrder");
                Console.WriteLine("2 --> GetAllCouriers");
                Console.WriteLine("3 --> GetOrderStatus");
                Console.WriteLine("4 --> GetAssignedOrder");
                Console.WriteLine("5 --> GetOrderById");
                Console.WriteLine("6 --> UpdateOrder");
                int key = int.Parse(Console.ReadLine());

                ICourierUserService courieruserService = new CourierUserService();

                switch (key)
                {
                    case 1:
                        courieruserService.placeOrder();
                        break;
                    case 2:
                        courieruserService.GetAllCouriers();
                        break;
                    case 3:
                        courieruserService.getOrderStatus();
                        break;
                    case 4:
                        courieruserService.getAssignedOrder();
                        break;
                    case 5:
                        courieruserService.getOrderById();
                        break;
                    case 6:
                        courieruserService.updateOrder();
                        break;
                    default:
                        Console.WriteLine("Enter a valid key.");
                        break;

                }
            }

            static void CourierAdminImplement()
            {
                Console.WriteLine("Welcome to CourierAdminService,Press key to go ahead..");
                Console.WriteLine("1 --> AddCourierStaff");
                
                int key = int.Parse(Console.ReadLine());

                ICourierAdminService courierAdminService = new CourierAdminService();

                switch (key)
                {
                    case 1:
                        courierAdminService.addCourierStaff();
                        break;
                    default:
                        Console.WriteLine("Enter a valid key.");
                        break;

                }
            } */
            #endregion


        }
    }
}
