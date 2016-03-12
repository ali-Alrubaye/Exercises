using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
     class Car: Vehicle
    {
        // Fields
        private bool engineIsRunning;
        
        //Inherited class constructor :
        public Car() : base("Car")
        {
            engineIsRunning = false;
          
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

        public override string DescribeVehicle()
        {
            string running;


            if (engineIsRunning)
                running = "running";
            else
                running = "not running";


            return string.Format("{0}, where the engine is {1}", base.DescribeVehicle(), running);
        } 
           

    }
}
