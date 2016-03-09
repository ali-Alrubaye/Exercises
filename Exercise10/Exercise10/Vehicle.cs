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
        private string _vehicleType;
        
        

        //Constructors
              
        public void addVehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
           
        }
        //Methods
        public string DescribeVehicle ()
        {
            return "This vehicle is a " + _vehicleType;
        }
        

       
    }
}
