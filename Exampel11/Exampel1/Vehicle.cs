using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
      public abstract class Vehicle
    {
        // Fields
        private string _vehicleType;
        
        //Constructors
              
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
           
        }
        //Methods
        public virtual string DescribeVehicle ()
        {
            return "This vehicle is a " + _vehicleType;
        }
       
    }
}
