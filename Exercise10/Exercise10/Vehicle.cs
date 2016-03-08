using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
      public class Vehicle
    {
        // Fields
        public string Model;
        public string Manufacturar;
        public string Year;
        public string RegNumber;
        

        //Constructors
        public Vehicle()
        { }
        public Vehicle (string model, string manufacturar,string year,string regNumber)
        {
            this.Model = model;
            this.Manufacturar = manufacturar;
            this.Year = year;
            this.RegNumber = regNumber;
        }
        //Methods
        public string DescribeVehicle ()
        {
            return "This vehicle is a " + Model + ", " + RegNumber + ", " + Manufacturar + " ," + Year;
        }
        

        //public string GetVehicleInfo()
        //{
        //    return RegNumber + ", " + Manufacturar + " ," + Year;
        //}
    }
}
