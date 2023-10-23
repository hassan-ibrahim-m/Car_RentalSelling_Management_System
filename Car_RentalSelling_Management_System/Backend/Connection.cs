using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Car_RentalSelling_Management_System
{
    
    public static class Connection
    {
        #region Connection
        static string connectString = @"Data Source=DESKTOP-AO339EH;Initial Catalog = CarAgancy; Integrated Security = True";
        static SqlConnection con;
        public static void OpenConection()
        {
            con = new SqlConnection(connectString);
            con.Open();
        }      

        public static void CloseConnection()
        {
            con.Close();
        }
        #endregion

        public static string Execute(string Query_)
        {
            string response = "0";
            string query = "begin try begin transaction " + Query_ + " commit select '1' as 'response' end try begin catch rollback select '0' as 'response' end catch";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                response = dr["response"].ToString();
            }
            dr.Close();
            return response;
        }

        public static User SelectUser(string username, string password)
        {
            string query = String.Format("select * from Users where ID = {0} and Password = {1}", username, "'" + password + "'");
            User user = new User();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user.phone = dr["ID"].ToString();
                user.fname = dr["FName"].ToString();
                user.sname = dr["SName"].ToString();
                user.accountType = dr["AccountType"].ToString();
                user.password = dr["Password"].ToString();
            }
            dr.Close();
            if (user.phone == "" || user.password != password)
                return null;
            else
                return user;           
        }

        public static List<Operation> SelectOperations(string userID)
        {
            string query = String.Format("select c.CarModel, c.Type, c.PricePerDay * DATEDIFF(Day, StartDate, EndDate) as 'Cost', 'Rent' as 'Operation' from car c, reservation r where c.ID = r.carID and r.UserID = '{0}' union select c.CarModel, c.Type, c.Price, 'Buy' as 'Operation' from car c, buy b where c.ID = b.carID and b.UserID = '{0}' order by Operation", userID);
            List<Operation> operations = new List<Operation>();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {              
                string carModel = dr["CarModel"].ToString();
                string type = dr["Type"].ToString();
                string cost = dr["Cost"].ToString();
                string operation = dr["Operation"].ToString();
                operations.Add(new Operation(carModel, type, cost, operation));
            }
            dr.Close();
            return operations;
        }

        public static User InsertUser(string ID, string FName, string SName, string AccountType, string password) //Register
        {
            string query = "insert into users (ID, FName, SName, AccountType, password) " + "values(@ID,@FName, @SName, @AccountType, @password)";
            User user = new User();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user.phone = dr["ID"].ToString();
                user.fname = dr["FName"].ToString();
                user.sname = dr["SName"].ToString();
                user.accountType = dr["AccountType"].ToString();
                user.password = dr["Password"].ToString();
            }
            dr.Close();

            return user;
        }

        public static List<Cars> SelectCars_buy(string manufacturer, string model, string minYear, string maxYear, string minCost, string maxCost, string type, string fuelType) 
        {
            List<Cars> cr = new List<Cars>();
            string query = String.Format("select * from car where Manufacturer = '{0}' and CarModel = '{1}' and Year between {2} and {3} and Price between {4} and {5} and Type = '{6}' and FuleType = '{7}'", manufacturer, model, minYear, maxYear, minCost, maxCost, type, fuelType);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ID = dr["ID"].ToString();
                string FuelType = dr["FuleType"].ToString();
                string Rate = dr["Rate"].ToString();
                string Price = dr["Price"].ToString();
                string PricePerDay = dr["PricePerDay"].ToString();
                string City = dr["City"].ToString();
                double KM = double.Parse(dr["KM"].ToString());
                double Year = double.Parse(dr["Year"].ToString());
                string Type = dr["Type"].ToString();
                string Manufacturer = dr["Manufacturer"].ToString();
                string CarModel = dr["CarModel"].ToString();
                string UserID = dr["UserID"].ToString();
                string Status = dr["Status"].ToString();

                Cars car = new Cars(ID, FuelType, double.Parse(Rate), double.Parse(Price), double.Parse(PricePerDay), City, KM, Year, Type, Manufacturer, CarModel, UserID, Status);
                cr.Add(car);
            }
            dr.Close();

            return cr;
        }

        public static List<Cars> SelectCars_rent(string manufacturer, string model, string minYear, string maxYear, string minCost, string maxCost, string type, string city)
        {
            List<Cars> cr = new List<Cars>();
            string query = String.Format("select * from car where Manufacturer = '{0}' and CarModel = '{1}' and Year between {2} and {3} and Price between {4} and {5} and Type = '{6}' and City = '{7}'", manufacturer, model, minYear, maxYear, minCost, maxCost, type, city);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ID = dr["ID"].ToString();
                string FuelType = dr["FuleType"].ToString();
                double Rate = double.Parse(dr["Rate"].ToString());
                double Price = double.Parse(dr["Price"].ToString());
                double PricePerDay = double.Parse(dr["PricePerDay"].ToString());
                string City = dr["City"].ToString();
                double KM = double.Parse(dr["KM"].ToString());
                double Year = double.Parse(dr["Year"].ToString());
                string Type = dr["Type"].ToString();
                string Manufacturer = dr["Manufacturer"].ToString();
                string CarModel = dr["CarModel"].ToString();
                string UserID = dr["UserID"].ToString();
                string Status = dr["Status"].ToString();

                Cars car = new Cars(ID, FuelType, Rate, Price, PricePerDay, City, KM, Year, Type, Manufacturer, CarModel, UserID, Status);
                cr.Add(car);
            }
            dr.Close();

            return cr;
        }

        public static Cars AddNewCar(string ID, string FName, string SName, string AccountType, string password) 
        {
            string query = "insert into[CarAgancy].[dbo].[car](ID, FuleType, Price, PricePerDay, City, KM, Year, Type, Manufacturer, CarModel, Status, UserID)values(@ID, @FuleType, @Price, @PricePerDay, @City, @KM, @Year, @Type, @Manufacturer, @CarModel, @Status, @UserID)";
            Cars cr = new Cars();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cr.CarID = dr["ID"].ToString();
                cr.FuelType = dr["FuleType"].ToString();
                cr.Price = float.Parse(dr["Price"].ToString());
                cr.PricePerDay = float.Parse(dr["PricePerDay"].ToString());
                cr.City = dr["City"].ToString();
                cr.KM = float.Parse(dr["KM"].ToString());
                cr.Year = double.Parse(dr["Year"].ToString());
                cr.Type = dr["Type"].ToString();
                cr.Manufacturer = dr["Manufacturer"].ToString();
                cr.CarModel = dr["CarModel"].ToString();
                cr.Status = dr["Status"].ToString();
                cr.UserID = dr["UserID"].ToString();
            }
            dr.Close();

            return cr;
        }

    }
}
