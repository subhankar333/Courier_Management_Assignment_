using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Courier_Management_Assignment.Model;
using System.Data.SqlClient;
using Courier_Management_Assignment.Utility;
using Courier_Management_Assignment.Exceptions;

namespace Courier_Management_Assignment.Repository
{
    internal class CourierUserRepository:ICourierUserRepository
    {
       
        //sql connection class
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public CourierUserRepository()
        {
            sqlconnection = new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }


        private bool OrderExistsforEmployee(int empId)
        {

            SqlConnection sqlconnection = new SqlConnection(DbConnUtil.GetConnectionString()); ;
            SqlCommand cmd = new SqlCommand(); ;
            cmd.CommandText = "select * from Employee where EmployeeID = @empId";
            cmd.Parameters.AddWithValue("@empId", empId);
            cmd.Connection = sqlconnection;
            sqlconnection.Open();

            object obj = cmd.ExecuteScalar();
            //Console.WriteLine(obj);s
            return obj != null;
        }

        private bool CourierExists(string trackingNo)
        {

            SqlConnection sqlconnection = new SqlConnection(DbConnUtil.GetConnectionString()); ;
            SqlCommand cmd = new SqlCommand(); ;
            cmd.CommandText = "select * from Courier where Tracking_Number = @trackingNo";
            cmd.Parameters.AddWithValue("@trackingNo", trackingNo);
            cmd.Connection = sqlconnection;
            sqlconnection.Open();

            object obj = cmd.ExecuteScalar();
            //Console.WriteLine(obj);s
            return obj != null;
        }


        public List<Courier> GetAllCouriers()
        {
            List<Courier> courierList = new List<Courier>();
            cmd.CommandText = "select * from Courier";
            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Courier courier = new Courier();
                courier.CourierID = (int)reader["CourierID"];
                courier.Sender_Name = (string)reader["Sender_Name"];
                courier.Sender_Address = (string)reader["Sender_Address"];
                courier.Receiver_Name = (string)reader["Receiver_Name"];
                courier.Receiver_Address = (string)reader["Receiver_Address"];
                courier.Weight = (decimal)reader["Weight"];
                courier.Status = (string)reader["Status"];
                courier.Tracking_Number = (string)reader["Tracking_Number"];
                courier.Delivery_Date = (DateTime)reader["Delivery_Date"];
                courier.ServiceId = (int)reader["ServiceId"];
                courier.EmployeeId = (int)reader["EmployeeId"];
                courier.UserId = (int)reader["UserId"];
                courierList.Add(courier);
            }
            sqlconnection.Close();
            return courierList;
        }


         public string placeOrder(Courier courier)
        {
            cmd.CommandText = "insert into Courier values(@CourierID,@Sender_Name,@Sender_Address,@Receiver_Name,@Receiver_Address,@Weight,@Status,@Tracking_Number,@Delivery_Date,@ServiceId,@EmployeeId,@UserId)";
            cmd.Parameters.AddWithValue("@CourierID", courier.CourierID);
            cmd.Parameters.AddWithValue("@Sender_Name", courier.Sender_Name);
            cmd.Parameters.AddWithValue("@Sender_Address", courier.Sender_Address);
            cmd.Parameters.AddWithValue("@Receiver_Name", courier.Receiver_Name);
            cmd.Parameters.AddWithValue("@Receiver_Address", courier.Receiver_Address);
            cmd.Parameters.AddWithValue("@Weight", courier.Weight);
            cmd.Parameters.AddWithValue("@Status", courier.Status);
            cmd.Parameters.AddWithValue("@Tracking_Number", courier.Tracking_Number);
            cmd.Parameters.AddWithValue("@Delivery_Date", courier.Delivery_Date);
            cmd.Parameters.AddWithValue("@ServiceId", courier.ServiceId);
            cmd.Parameters.AddWithValue("@EmployeeId", courier.EmployeeId);
            cmd.Parameters.AddWithValue("@UserId", courier.UserId);
            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            int addUserStatus = cmd.ExecuteNonQuery();
            sqlconnection.Close();

            if (addUserStatus > 0)
                Console.WriteLine("Courier done successfully!");
            else
                Console.WriteLine("Courier not placed , try again entering data!");

            return courier.Tracking_Number;
        } 

        public Courier getOrderStatus(string trackNo)
        {
            try
            {
                if(!CourierExists(trackNo))
                {
                    throw new TrackingNumberNotFoundException($"Courier not found for tracking number-{trackNo}");
                }
                cmd.CommandText = "select * from Courier where Tracking_Number = @trackNo";
                cmd.Parameters.AddWithValue("@trackNo", trackNo);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Courier courier = new Courier();

                while (reader.Read())
                {
                    courier.CourierID = (int)reader["CourierID"];
                    courier.Sender_Name = (string)reader["Sender_Name"];
                    courier.Sender_Address = (string)reader["Sender_Address"];
                    courier.Receiver_Name = (string)reader["Receiver_Name"];
                    courier.Receiver_Address = (string)reader["Receiver_Address"];
                    courier.Weight = (decimal)reader["Weight"];
                    courier.Status = (string)reader["Status"];
                    courier.Tracking_Number = (string)reader["Tracking_Number"];
                    courier.Delivery_Date = (DateTime)reader["Delivery_Date"];
                    courier.ServiceId = (int)reader["ServiceId"];
                    courier.EmployeeId = (int)reader["EmployeeId"];
                    courier.UserId = (int)reader["UserId"];
                }
                sqlconnection.Close();
                return courier;
            }
            catch(TrackingNumberNotFoundException ex)
            {
                Console.WriteLine($"Error occured : {ex.Message}");
            }

            return null;
        }         

        public List<Courier> getAssignedOrder(int empId)
        {
            try
            {
                if(!OrderExistsforEmployee(empId))
                {
                    throw new InvalidEmployeeIdException($"No Order found for employee id-{empId}");
                }

                cmd.CommandText = "select * from Courier where EmployeeId = @empId";
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.Connection = sqlconnection;
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                List<Courier> courierList = new List<Courier>();

                while (reader.Read())
                {
                    Courier courier = new Courier();
                    courier.CourierID = (int)reader["CourierID"];
                    courier.Sender_Name = (string)reader["Sender_Name"];
                    courier.Sender_Address = (string)reader["Sender_Address"];
                    courier.Receiver_Name = (string)reader["Receiver_Name"];
                    courier.Receiver_Address = (string)reader["Receiver_Address"];
                    courier.Weight = (decimal)reader["Weight"];
                    courier.Status = (string)reader["Status"];
                    courier.Tracking_Number = (string)reader["Tracking_Number"];
                    courier.Delivery_Date = (DateTime)reader["Delivery_Date"];
                    courier.ServiceId = (int)reader["ServiceId"];
                    courier.EmployeeId = (int)reader["EmployeeId"];
                    courier.UserId = (int)reader["UserId"];
                    courierList.Add(courier);
                }
                sqlconnection.Close();
                return courierList;
            }
            catch(InvalidEmployeeIdException ex)
            {
                Console.WriteLine($"error occured: {ex.Message}");
            }

            return null;
        }

        public Courier getOrderById(int Id)
        {
            cmd.CommandText = "select * from Courier where CourierID = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Courier courier = new Courier();

            while (reader.Read())
            {
                courier.CourierID = (int)reader["CourierID"];
                courier.Sender_Name = (string)reader["Sender_Name"];
                courier.Sender_Address = (string)reader["Sender_Address"];
                courier.Receiver_Name = (string)reader["Receiver_Name"];
                courier.Receiver_Address = (string)reader["Receiver_Address"];
                courier.Weight = (decimal)reader["Weight"];
                courier.Status = (string)reader["Status"];
                courier.Tracking_Number = (string)reader["Tracking_Number"];
                courier.Delivery_Date = (DateTime)reader["Delivery_Date"];
                courier.ServiceId = (int)reader["ServiceId"];
                courier.EmployeeId = (int)reader["EmployeeId"];
                courier.UserId = (int)reader["UserId"];
            }
            sqlconnection.Close();
            return courier;
        } 

        public bool updateOrder(int Id, string address)
        {
            cmd.CommandText = "update Courier set Receiver_Address = @address where CourierID = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@address", address);

            cmd.Connection = sqlconnection;
            sqlconnection.Open();
            int addUserStatus = cmd.ExecuteNonQuery();
            sqlconnection.Close();

            return true;
        }

    }
}
