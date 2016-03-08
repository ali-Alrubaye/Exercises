using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var MyVehicle = new VehicleData();
            
            var myCar = new Car();
            myCar.Model = "BMV";
            myCar.Manufacturar = "Swd";
            myCar.RegNumber = "AAA123";
            myCar.Year = "2016";
          
            MyVehicle.PrintVehicle(myCar);

         }
    }
    
}
