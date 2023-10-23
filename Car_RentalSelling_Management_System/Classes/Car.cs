using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_RentalSelling_Management_System
{
    public class Cars
    {
        public string CarID { get; set; }
        public string FuelType { get; set; }
        public double Rate { get; set; }
        public double Price { get; set; }
        public double PricePerDay { get; set; }
        public string City { get; set; }
        public double KM { get; set; }
        public double Year { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string CarModel { get; set; }
        public string UserID { get; set; }
        public string Status { get; set; }
       
        public Cars(string CarID, string FuelType, double Rate, double Price, double PricePerDay, string City, double KM, double Year, string Type, string Manufacturer, string CarModel, string UserID, string Status)
        {
            this.CarID = CarID;
            this.FuelType = FuelType;
            this.Rate = Rate;
            this.Price = Price;
            this.PricePerDay = PricePerDay;
            this.City = City;
            this.KM = KM;
            this.Year = Year;
            this.Manufacturer = Manufacturer;
            this.CarModel = CarModel;
            this.UserID = UserID;
            this.Status = Status;
        }

        public Cars()
        {

        }
    }
}
