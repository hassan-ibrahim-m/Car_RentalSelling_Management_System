using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_RentalSelling_Management_System
{
    public class Operation
    {
        public string CarModel { get; set; }
        public string Type { get; set; }
        public string Cost { get; set; }
        public string OpName { get; set; }

        public Operation(string CarModel, string Type, string Cost, string OpName)
        {
            this.CarModel = CarModel;
            this.Type = Type;
            this.Cost = Cost;
            this.OpName = OpName;
        }
    }
}
