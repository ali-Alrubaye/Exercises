using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Car: Vehicle
    {
        // Fields
        //private string manufacturar;
        //private string year;
        //private string regNumber;
        private bool engineIsRunning;
        
        //Inherited class constructor :
        public Car()
        {
            engineIsRunning = false;
            addVehicle("car");
            //this.Manufacturar = manufacturar;
            //this.Year = year;
            //this.RegNumber = regNumber;
        }

        public bool StartEngine()
        {
            // If the Engine is already Start, the action fails
            if (engineIsRunning)
                return false;
            engineIsRunning = true;
            return true;
        }
        // If the Engine is already stop, the action fails
        public bool StopEngine()
        {
            if (!engineIsRunning)
                return false;
            engineIsRunning = false;
            return true;
        }

       

    }
}
